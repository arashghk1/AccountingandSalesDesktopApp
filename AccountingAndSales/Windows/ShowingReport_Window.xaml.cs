using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for ShowingReport_Window.xaml
    /// </summary>
    public partial class ShowingReport_Window : Window
    {
        public ShowingReport_Window()
        {
            InitializeComponent();
        }

        public string ReportType { get; set; }
        public string GetFormula { get; set; }

        public string[] Params=new string[10];

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (ReportType != null)
            {
                ReportDocument reportDocument = new ReportDocument();
                string Path = System.AppDomain.CurrentDomain.BaseDirectory + "Reporting\\" + this.ReportType;
                reportDocument.Load(Path);
                reportDocument.RecordSelectionFormula = this.GetFormula;

                switch (ReportType)
                {
                    case "CustomerList.rpt":
                        {
                            reportDocument.SetParameterValue("DateReporting", DateTime.Now.ToString("dd/MM/yyyy"));
                            break;
                        }
                    case "AllSelling_Report.rpt":
                        {                       
                            reportDocument.SetParameterValue("DateNowPrepare", DateTime.Now.ToString("dd/MM/yyyy"));
                            reportDocument.SetParameterValue("FromDate" , Params[0]);
                            reportDocument.SetParameterValue("ToDate" , Params[1]);
                            break;
                        }
                    case "SellingAll_CustomerGroup.rpt":
                        {
                            reportDocument.SetParameterValue("DateNowPrepare", DateTime.Now.ToString("dd/MM/yyyy"));
                            reportDocument.SetParameterValue("FromDate", Params[0]);
                            reportDocument.SetParameterValue("ToDate", Params[1]);
                            break;
                        }
                    case "Invoice_Report.rpt":
                        {
                            reportDocument.SetParameterValue("InvoiceID", Params[0]);
                            reportDocument.SetParameterValue("CustomerName", Params[1]);
                            reportDocument.SetParameterValue("CustomerAddress", Params[2]);
                            reportDocument.SetParameterValue("CustomerPhoneNumber", Params[3]);
                            reportDocument.SetParameterValue("InvoiceDateTime", Params[4]);
                            reportDocument.SetParameterValue("AmountPayAble", Params[5]);
                            reportDocument.SetParameterValue("InvoiceType", Params[6]);
                            reportDocument.SetParameterValue("InvoicePrintDate", DateTime.Now.ToString("dd/MM/yyyy"));


                            break;
                        }
                }

                

                CRV_Component.ViewerCore.ReportSource = reportDocument;
            }
            else
            {
                MessageBox.Show("Report Is Not Exist Or Not Loaded!\n\tPlease Try Again", "Accounting And Sales", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
