using FR.BL.Algo;
using FR.DBAccess;
using FR.Domin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.BL
{
    public class FaceProcess {

        FRContext cnt = new FRContext();
        readonly string path= @"E:\STUDENT PROJECTS\MALSHA\FR\FR.BL\FaceInfo";
        public void SaveFace(Faces f) {

            try
            {
                // create guid
                var fname = Guid.NewGuid().ToString() + ".jpg";
                f.ImageName = fname;
                cnt.Faces.Add(f);
                // save image
                File.WriteAllBytes($"{path}/db/{fname}", System.Convert.FromBase64String(f._64BaseImage));
                cnt.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<FaceRecognizer> FindFace(Bitmap image,double treshold) {

            var imageInfo = cnt.Faces.ToList();
            var resultList = new List<FaceRecognizer>();
            foreach (Enums.EAlgo foo in Enum.GetValues(typeof(Enums.EAlgo))) {

                switch (foo)
                {
                    case Enums.EAlgo.EigenFaceRecognizer:
                        resultList.AddRange(Proccesor.EigenFaceRecognizer(imageInfo, image));
                        break;
                    case Enums.EAlgo.FisherFaceRecognizer:
                        resultList.AddRange(Proccesor.FisherFaceRecognizer(imageInfo, image));
                        break;
                    case Enums.EAlgo.LBPHFaceRecognizer:
                        resultList.AddRange(Proccesor.LBPHFaceRecognizer(imageInfo, image));
                        break;
                    case Enums.EAlgo.Aforge:
                        resultList.AddRange(Proccesor.Aforge(imageInfo, image));
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            return resultList;
        }
    }
}
