using FR.Domin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.BL.Algo
{
    public class Proccesor
    {
        public static List<FaceRecognizer> EigenFaceRecognizer(List<Faces> f, Bitmap currentImage)
        {

            return new List<FaceRecognizer> {
                new FaceRecognizer {
                PersonId = "1254450",
                TimeIn = DateTime.Now,
                TimeOut = DateTime.Now.AddSeconds(1),
                Algo = Enums.EAlgo.EigenFaceRecognizer }
            };

        }
        public static List<FaceRecognizer> FisherFaceRecognizer(List<Faces> f, Bitmap currentImage)
        {
            return new List<FaceRecognizer> {
                new FaceRecognizer {
                PersonId = "1254450",
                TimeIn = DateTime.Now,
                TimeOut = DateTime.Now.AddSeconds(3),
                Algo = Enums.EAlgo.FisherFaceRecognizer
                }
            };

        }
        public static List<FaceRecognizer> LBPHFaceRecognizer(List<Faces> f, Bitmap currentImage)
        {
            return new List<FaceRecognizer> {
                new FaceRecognizer {
                PersonId = "1254450",
                TimeIn = DateTime.Now,
                TimeOut = DateTime.Now.AddSeconds(2),
                Algo = Enums.EAlgo.LBPHFaceRecognizer
                }
            };

        }
        public static List<FaceRecognizer> Aforge(List<Faces> f, Bitmap currentImage)
        {
            return new List<FaceRecognizer> {
                new FaceRecognizer {
                PersonId = "1254450",
                TimeIn = DateTime.Now,
                TimeOut = DateTime.Now.AddSeconds(1),
                Algo = Enums.EAlgo.Aforge
                },
                new FaceRecognizer {
                     PersonId = "1254450",
                TimeIn = DateTime.Now,
                TimeOut = DateTime.Now.AddMilliseconds(1),
                 Algo = Enums.EAlgo.Aforge
                },
                };

        }
    }
}
