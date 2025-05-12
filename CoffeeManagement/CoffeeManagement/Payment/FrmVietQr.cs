using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
namespace PresentationLayer.Payment
{
    public partial class FrmVietQr : Form
    {
        float totalPrice = 0;   
        public FrmVietQr(float total)
        {
            InitializeComponent();
            totalPrice = total; 
            //GenQr();

        }
        // Add this helper method to convert a Base64 string to an Image object.
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        // Update the problematic line to handle potential null references.
        private void btn_genQR_Click(object sender, EventArgs e)
        {
            GenQr();
        }
        //    {
        //  "accountNo": 113366668888,
        //  "accountName": "QUY VAC XIN PHONG CHONG COVID",
        //  "acqId": 970415,
        //  "amount": 79000,
        //  "addInfo": "Ung Ho Quy Vac Xin",
        //  "format": "text",
        //  "template": "compact"
        //}
        private void GenQr()
        {
            var apiRequest = new ApiRequest();
            //apiRequest.acqId = Convert.ToInt32(cb_nganHang.SelectedValue);
            //apiRequest.accountNo = long.Parse(txt_SoTaiKhoan.Text);
            //apiRequest.accountName = txtTenTaiKhoan.Text;
            //apiRequest.amount = Convert.ToInt32(txtSoTien.Text);
            //apiRequest.format = "text";
            //apiRequest.template = cb_Template.Text;
            apiRequest.acqId = 970415;
            apiRequest.accountNo = 113366668888;
            apiRequest.accountName = "VO DUY KHOI";
            apiRequest.amount = 79000;
            apiRequest.format = "text";
            apiRequest.template = "compact";

            var jsonRequest = JsonConvert.SerializeObject(apiRequest);

            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content;
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            pic_QR.Image = image;
        }

        private void FrmVietQr_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {

                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJon = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJon);
                cb_nganHang.DataSource = listBankData.data;
                cb_nganHang.DisplayMember = "custom_name";
                cb_nganHang.ValueMember = "bin";
                //cb_nganHang.EditValue
                cb_nganHang.SelectedIndex = -1;
                cb_Template.SelectedIndex = -1;
                cb_Template.Items.Add("compact");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
