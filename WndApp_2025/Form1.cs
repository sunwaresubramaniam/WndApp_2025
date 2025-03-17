using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MTLS_Cert_Lib;

namespace WndApp_2025
{
    public partial class frmMTLSCertTesting : Form
    {

        string clientCertificatePath;
        string clientCertificatePassword;
        public frmMTLSCertTesting()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clientCertificatePath = @"C:/Subbu/MTLS/Cert/SunwareClientCertificate25.pfx";
            clientCertificatePassword = "Test@123";
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            this.txtResult.Clear();
            this.txtUrl.Clear();
        }

        private void cmdFetch_Click(object sender, EventArgs e)
        {
            //https://localhost:7130/api/Country/GetAllCountries
            //https://localhost:7130/api/Customer/GetAllCustomers
            //https://localhost:7130/api/User/GetAllUsers

            this.txtResult.Text = string.Empty;
            this.txtResult.Text = "Loading.. Please Wait";
            if (!string.IsNullOrEmpty(this.txtUrl.Text))
            {
                this.txtResult.Text = this.txtResult.Text + "\r\n  Load the Certificate";
                try
                {
                    //MTLS_Cert_Lib.MTLSClientCertificate.ClientCertificatePath = clientCertificatePath;
                    //MTLS_Cert_Lib.MTLSClientCertificate.ClientCertificatePassword = clientCertificatePassword;
                    MTLS_Cert_Lib.MTLSClientCertificate.ClientCertificate_CacheKey = "Testsubbu";
                    //X509Certificate2 certificate = new X509Certificate2(clientCertificatePath, clientCertificatePassword);


                    MTLS_Cert_Lib.MTLSClientCertificate.LoadCertificate();
                    this.txtResult.Text = this.txtResult.Text + "\r\n  Creating the HttpClient";
                    //HttpClient client = clientCertificate.CreateHttpClientWithCertificate(certificate);
                    HttpClient client = MTLS_Cert_Lib.MTLSClientCertificate.CreateHttpClientAutomatic();
                    this.txtResult.Text = this.txtResult.Text + "\r\n  Creating the HttpClient Response";
                    this.txtResult.Text = this.txtResult.Text + "\r\n  Calling HttpClient Response";
                    //HttpResponseMessage response = MTLS_Cert_Lib.MTLSClientCertificate.HttpClientGet(client, this.txtUrl.Text);
                    HttpResponseMessage response = MTLS_Cert_Lib.MTLSClientCertificate.HttpClientSend(MTLS_Cert_Lib.HttpMethodEnum.GET, client, this.txtUrl.Text);
                    this.txtResult.Text = this.txtResult.Text + "\r\n  Getting the Response";
                    string responseContent = MTLS_Cert_Lib.MTLSClientCertificate.GetHttpResponseContent(response);
                    this.txtResult.Text = responseContent;
                  
                }
                catch(Exception ex)
                {
                    this.txtResult.Text = this.txtResult.Text + "\r\n  Failed to execute:"+ex.Message;
                }
            }
            else
            {
                this.txtResult.Text = this.txtResult.Text + "\r\n  Enter the Server Url";
            }
        }
    }
}
