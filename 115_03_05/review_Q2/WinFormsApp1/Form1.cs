using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const decimal OIL_CHANGE_FEE = 780m;
        private const decimal LUBE_SERVICE_FEE = 540m;
        private const decimal RADIATOR_FLUSH_FEE = 900m;
        private const decimal TRANS_FLUSH_FEE = 2400m;
        private const decimal INSPECTION_FEE = 450m;
        private const decimal MUFFLER_REPLACE_FEE = 3000m;
        private const decimal TIRE_ROTATION_FEE = 600m;
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal PARTS_TAX_RATE = 0.06m;

        public Form1()
        {
            InitializeComponent();

            // Attach event handlers
            btnCalculate.Click += calculateButton_Click;
            btnClear.Click += clearButton_Click;
            btnExit.Click += exitButton_Click;
        }

        // Service calculation methods
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (chkOilChange.Checked) total += OIL_CHANGE_FEE;
            if (chkLubeService.Checked) total += LUBE_SERVICE_FEE;
            return total;
        }

        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (chkRadiatorFlush.Checked) total += RADIATOR_FLUSH_FEE;
            if (chkTransFlush.Checked) total += TRANS_FLUSH_FEE;
            return total;
        }

        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (chkInspection.Checked) total += INSPECTION_FEE;
            if (chkMufflerReplace.Checked) total += MUFFLER_REPLACE_FEE;
            if (chkTireRotation.Checked) total += TIRE_ROTATION_FEE;
            return total;
        }

        private decimal OtherCharges(out decimal partsCost, out decimal laborCost)
        {
            // parts
            partsCost = 0m;
            laborCost = 0m;

            if (!decimal.TryParse(txtPartsCost.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out partsCost))
            {
                // try with current culture
                decimal.TryParse(txtPartsCost.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out partsCost);
            }

            if (partsCost < 0m)
            {
                MessageBox.Show("零件費用不可為負值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartsCost.Focus();
                partsCost = 0m;
            }

            // labor hours
            decimal hours = 0m;
            if (!decimal.TryParse(txtLaborHours.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out hours))
            {
                decimal.TryParse(txtLaborHours.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out hours);
            }

            if (hours < 0m)
            {
                MessageBox.Show("工時數不可為負值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLaborHours.Focus();
                hours = 0m;
            }

            laborCost = hours * LABOR_RATE_PER_HOUR;

            return partsCost + laborCost; // not used directly by UI but provided
        }

        private decimal TaxCharges(decimal partsCost)
        {
            if (partsCost <= 0m) return 0m;
            return Math.Round(partsCost * PARTS_TAX_RATE, 2);
        }

        private decimal TotalCharges(decimal serviceAndLabor, decimal partsCost, decimal tax)
        {
            return serviceAndLabor + partsCost + tax;
        }

        // Event handlers
        private void calculateButton_Click(object? sender, EventArgs e)
        {
            // Calculate selected services
            decimal oilLube = OilLubeCharges();
            decimal flush = FlushCharges();
            decimal misc = MiscCharges();

            // Other charges
            decimal partsCost;
            decimal laborCost;
            OtherCharges(out partsCost, out laborCost);

            decimal serviceAndLabor = oilLube + flush + misc + laborCost;
            decimal tax = TaxCharges(partsCost);
            decimal total = TotalCharges(serviceAndLabor, partsCost, tax);

            // Format as currency NT$
            txtServiceAndLabor.Text = FormatCurrencyNoDecimal(serviceAndLabor);
            txtPartsSummary.Text = FormatCurrencyNoDecimal(partsCost);
            txtPartsTax.Text = FormatCurrencyNoDecimal(tax);
            txtTotalCost.Text = FormatCurrencyNoDecimal(total);
        }

        private void clearButton_Click(object? sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("是否要儲存維修明細？", "儲存", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            if (result == DialogResult.Yes)
            {
                SaveServiceDetailsToFile();
            }

            Close();
        }

        // Clear methods
        private void ClearOilLube()
        {
            chkOilChange.Checked = false;
            chkLubeService.Checked = false;
        }

        private void ClearFlushes()
        {
            chkRadiatorFlush.Checked = false;
            chkTransFlush.Checked = false;
        }

        private void ClearMisc()
        {
            chkInspection.Checked = false;
            chkMufflerReplace.Checked = false;
            chkTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            txtPartsCost.Text = string.Empty;
            txtLaborHours.Text = string.Empty;
        }

        private void ClearFees()
        {
            txtServiceAndLabor.Text = string.Empty;
            txtPartsSummary.Text = string.Empty;
            txtPartsTax.Text = string.Empty;
            txtTotalCost.Text = string.Empty;
        }

        // File save method
        private void SaveServiceDetailsToFile()
        {
            try
            {
                // Ensure latest calculation before saving
                calculateButton_Click(null, EventArgs.Empty);

                using var sfd = new SaveFileDialog();
                sfd.Title = "儲存維修明細";
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FileName = "ServiceDetails_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                var sb = new StringBuilder();
                sb.AppendLine("汽車維修服務 - 維修明細");
                sb.AppendLine("日期: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                sb.AppendLine(new string('-', 60));
                sb.AppendLine("已選擇服務:");

                if (chkOilChange.Checked) sb.AppendLine(" - 更換機油: " + FormatCurrencyNoDecimal(OIL_CHANGE_FEE));
                if (chkLubeService.Checked) sb.AppendLine(" - 潤滑保養: " + FormatCurrencyNoDecimal(LUBE_SERVICE_FEE));
                if (chkRadiatorFlush.Checked) sb.AppendLine(" - 水箱清洗: " + FormatCurrencyNoDecimal(RADIATOR_FLUSH_FEE));
                if (chkTransFlush.Checked) sb.AppendLine(" - 變速箱清洗: " + FormatCurrencyNoDecimal(TRANS_FLUSH_FEE));
                if (chkInspection.Checked) sb.AppendLine(" - 檢驗: " + FormatCurrencyNoDecimal(INSPECTION_FEE));
                if (chkMufflerReplace.Checked) sb.AppendLine(" - 更換消音器: " + FormatCurrencyNoDecimal(MUFFLER_REPLACE_FEE));
                if (chkTireRotation.Checked) sb.AppendLine(" - 輪胎換位: " + FormatCurrencyNoDecimal(TIRE_ROTATION_FEE));

                sb.AppendLine();

                // parts and labor
                decimal partsCost = 0m;
                decimal laborCost = 0m;
                OtherCharges(out partsCost, out laborCost);

                sb.AppendLine("零件費用: " + FormatCurrencyNoDecimal(partsCost));
                sb.AppendLine("工時數 (小時): " + (decimal.TryParse(txtLaborHours.Text.Trim(), out var h) ? h.ToString() : "0"));
                sb.AppendLine("工時費用 (NT$600/時): " + FormatCurrencyNoDecimal(laborCost));

                sb.AppendLine();

                decimal serviceAndLabor = OilLubeCharges() + FlushCharges() + MiscCharges() + laborCost;
                decimal tax = TaxCharges(partsCost);
                decimal total = TotalCharges(serviceAndLabor, partsCost, tax);

                sb.AppendLine("服務與工資總額: " + FormatCurrencyNoDecimal(serviceAndLabor));
                sb.AppendLine("零件稅金 (6%): " + FormatCurrencyNoDecimal(tax));
                sb.AppendLine("總費用: " + FormatCurrencyNoDecimal(total));

                sb.AppendLine(new string('-', 60));
                sb.AppendLine("感謝您的使用。 電話: (請輸入店家資訊)");

                // Write file with UTF8
                using var writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(false));
                writer.Write(sb.ToString());

                MessageBox.Show("已成功儲存維修明細。", "儲存完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存檔案時發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string FormatCurrencyNoDecimal(decimal amount)
        {
            // Format as NT$ with thousand separators and two decimals if needed
            // If amount has no fractional part, show no decimals
            if (decimal.Round(amount, 2) == Math.Floor(amount))
            {
                return "NT$" + string.Format(CultureInfo.InvariantCulture, "{0:N0}", amount);
            }
            return "NT$" + string.Format(CultureInfo.InvariantCulture, "{0:N2}", amount);
        }
    }
}
