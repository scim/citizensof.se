using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace citizensof.se.Data
{
    public class SwishService
    {
        public Task<SwishResult> MakePaymentRequestAsync(string reference, string payee)
        {
            var rng = new Random();
            return Task.FromResult(MakePaymentRequest(reference, payee));
        }

        private SwishResult MakePaymentRequest(string reference, string payee)
        {
            string certificatePath = Environment.CurrentDirectory + "\\TestCert\\Swish_Merchant_TestCertificate_1234679304.p12";
            var client = new SwishApi.Client(certificatePath, "swish", "https://tabetaltmedswish.se/Test/Callback/");

            var response = client.MakePaymentRequestMCommerce(1, "Test");
            var qrCode = client.GetQRCode(response.Token, "svg");
            var result = new SwishResult();



            if (!string.IsNullOrEmpty(qrCode.Error))
            {

            }
            else
            {
                result.QrCode = qrCode.SVGData;
            }

            return result;
        }
    }
}
