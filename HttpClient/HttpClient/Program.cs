

using System.Text;
using System.Security.Cryptography;
namespace HttpClientProgram {

    class Program {

        public static async Task<string> getData(string url) {
            using var httpClient = new HttpClient();
            try {
                var httpResponse = await httpClient.GetAsync(url);
                string html = await httpResponse.Content.ReadAsStringAsync();
                return html;
            } catch (Exception e) {
                Console.WriteLine(e);
                return "Error";
            }
        }
        
        
        public static async Task<byte[]> DownloadData(string url) {
            using var httpClient = new HttpClient();
            try {
                var httpResponse = await httpClient.GetAsync(url);
                var bytes = await httpResponse.Content.ReadAsByteArrayAsync();
                return bytes;
            } catch (Exception e) {
                Console.WriteLine(e);
                return null;
            }
        }
        
        public static async Task DownloadStream(string url, string fileName) {
            using HttpClient httpClient = new HttpClient();
            try {
                var response = await httpClient.GetAsync(url);
                using var webStream = await response.Content.ReadAsStreamAsync();
                using var fileStream = File.OpenWrite(fileName);

                int SIZE_BUFF = 256;
                byte[] buffer = new byte[SIZE_BUFF];
                bool endRead = false;
                int byteRead = 0;
                do {
                    byteRead = await webStream.ReadAsync(buffer, 0 ,SIZE_BUFF);
                    if (byteRead == 0) endRead = true;
                    else 
                        await fileStream.WriteAsync(buffer, 0, SIZE_BUFF);
                } while (!endRead);



            } catch (Exception e) {
                Console.WriteLine(e);
                return;
            }


        }
        static async Task Main() {
            // string url = "https://substackcdn.com/image/fetch/w_1456,c_limit,f_webp,q_auto:good,fl_progressive:steep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F0ac388d6-b2c7-4225-80f2-3ffc50836256_3738x2305.png";
            // string fileName = "picture.png";
            // await DownloadStream(url, fileName);

            using var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.RequestUri = new Uri("https://postman-echo.com/post");
            httpRequestMessage.Method = HttpMethod.Post;

            string payload = @"
                'name': 'Quynh',
                'first' : 'Nguyet'
            ";

            var content = new StringContent(payload, Encoding.UTF8, "application/json");
            httpRequestMessage.Content = content;            

            using var httpClient = new HttpClient();
            var res = await httpClient.SendAsync(httpRequestMessage);
            var data = await res.Content.ReadAsStringAsync();  
            Console.WriteLine(data);



        }

        // static async Task Main() {
        //     string url = "https://cldup.com/trzFLWwXSK-3000x3000.png";
        //     string fileName = "picture.png";

        //     HttpClient httpClient = new HttpClient();
        //     byte[] bytes = await httpClient.GetByteArrayAsync(url);  // Method Get

        //     var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
        //     stream.Write(bytes, 0, bytes.Length);
        // }



    }
}