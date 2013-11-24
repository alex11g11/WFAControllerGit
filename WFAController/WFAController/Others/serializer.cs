using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WFAController.Others
{
    class Serializer
    {
        /// <summary>
        /// Функция сериализует обьект класса Packet в массив байт
        /// </summary>
        /// <param name="packet"> Обьект для серилизации</param>
        /// <returns> Массив байт полученый при серилизации </returns>
        public static byte[] serialize(Object obj, Type type)
        {
            MemoryStream stream = new MemoryStream();
            XmlSerializer xml = new XmlSerializer(type);
            try
            {
                xml.Serialize(stream, obj);
            }
            catch (Exception e)
            {
                //MessageBox.Show("Ошибка сериализации: " + e.ToString());
                return null;                
            }
            stream.Seek(0, 0);
            byte[] msg = stream.GetBuffer();
            return msg;
        }
        /// <summary>
        /// Функция десериализует массив байт в обьект класса Packet 
        /// </summary>
        /// <param name="buffer">массив байт для десерилизации</param>
        /// <returns>обьект класса Packet полученый при десерилизации</returns>
        public static Object deserialize(byte[] buffer, Type type)
        {
            Object obj = null;

            MemoryStream mstr = new MemoryStream(buffer);
            XmlSerializer xml = new XmlSerializer(type);
            mstr.Seek(0, 0);

            try
            {
                obj = xml.Deserialize(mstr);
            }
            catch (Exception e)
            {
                //MessageBox.Show("Ошибка десериализации: " + e.ToString());
                return null;
            }

            return obj;
        }
    }
}
