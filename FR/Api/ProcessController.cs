using FR.BL;
using FR.Domin;
using FR.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FR.Api
{
    public class ProcessController : ApiController
    {
        private FaceProcess pros;
        public ProcessController()
        {
            pros = new FaceProcess();
        }
        [HttpPost]
        public async Task<HttpResponseMessage> TrainFace(FaceInfo f)
        {

            try
            {
                pros.SaveFace(new Faces
                {
                    _64BaseImage = f.Image,
                    Nic = f.Nic,
                    Name = f.Name
                });
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }
        [HttpGet]
        public async Task<HttpResponseMessage> FindFace(FaceInfo f)
        {

            try
            {
                f = new FaceInfo();
                var res = pros.FindFace(ToImage(f.Image),f.Treshold);
                return Request.CreateResponse<IEnumerable<FaceRecognizer>>(
                 HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public Bitmap ToImage(string image)
        {
            return null;
        }
    }
}
