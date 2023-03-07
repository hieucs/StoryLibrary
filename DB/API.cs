using HtmlAgilityPack;
using Newtonsoft.Json;
using StoryLibrary.Model;
using System.Net;
using System.Text;

namespace StoryLibrary.DB
{
    public static class API
    {
        public static List<MenuItem> MenuGet()
        {
            var list = new List<MenuItem>();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.hhtruyen.com/api/app/menuget");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept-Language", "vi");

            string json = "";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var responsebody = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(responsebody.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Memu>(result).MenuList;
                }
            }
            catch (Exception exx)
            {
                return list;
            }
            return list;
        }
        public static List<Item> SliderGet()
        {
            var list = new List<Item>();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.hhtruyen.com/api/app/SliderGet");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept-Language", "vi");

            string json = "";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var responsebody = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(responsebody.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Sliders>(result).Slider;
                }
            }
            catch (Exception exx)
            {
                return list;
            }
            return list;
        }
        public static List<Item> TruyenHotGet()
        {
            var list = new List<Item>();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.hhtruyen.com/api/app/TruyenHotGet");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept-Language", "vi");

            string json = "";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var responsebody = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(responsebody.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Sliders>(result).Slider;
                }
            }
            catch (Exception exx)
            {
                return list;
            }
            return list;
        }
        public static List<Item> TruyenMoiCapNhatGet()
        {
            var list = new List<Item>();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.hhtruyen.com/api/app/TruyenMoiCapNhatGet");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept-Language", "vi");

            string json = "";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var responsebody = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(responsebody.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Sliders>(result).Slider;
                }
            }
            catch (Exception exx)
            {
                return list;
            }
            return list;
        }
        public static ListItem ItemGet(string ID)
        {
            var list = new ListItem();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.hhtruyen.com/api/app/ItemGet");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept-Language", "vi");

            string json = "{\"ID\":\"" + ID + "\"}";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var responsebody = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(responsebody.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<ListItem>(result);
                }
            }
            catch (Exception exx)
            {
                return list;
            }
            return list;
        }

        public static CatetoryResult CategoryGet(CategoryParam param)
        {
            var list = new CatetoryResult();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.hhtruyen.com/api/app/CategoryGetByAlias");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept-Language", "vi");

            string json = JsonConvert.SerializeObject(param);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var responsebody = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(responsebody.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<CatetoryResult>(result);
                }
            }
            catch (Exception exx)
            {
                return list;
            }
            return list;
        }

        public static Chapter ChapterGet(ChapterParamGet param)
        {
            var chapter = new Chapter();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.hhtruyen.com/api/app/ChapterGet");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept-Language", "vi");

            string json = JsonConvert.SerializeObject(param);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var responsebody = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(responsebody.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    chapter = JsonConvert.DeserializeObject<ChapterList>(result).Chapter[0];
                    WebClient client = new WebClient();
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36 Edg/108.0.1462.54");
                    var htmlDocNoiDung = new HtmlDocument();
                    htmlDocNoiDung.LoadHtml(Encoding.UTF8.GetString(client.DownloadData(chapter.Link)));
                    chapter.Detail = htmlDocNoiDung.DocumentNode.SelectSingleNode("//*[@id=\"chapter-c\"]").InnerHtml;
                    if (htmlDocNoiDung.Text == "")
                    {
                        return null;
                    }
                    return chapter;
                }
            }
            catch (Exception exx)
            {
                return chapter;
            }
            return chapter;
        }
        public static List<Chapter> ChapterListGet(ListChapterParam param)
        {
            var chapters = new List<Chapter>();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.hhtruyen.com/api/app/ChapterList");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept-Language", "vi");

            string json = JsonConvert.SerializeObject(param);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var responsebody = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(responsebody.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    chapters = JsonConvert.DeserializeObject<ListChapter>(result).Chapters;
                    return chapters;
                }
            }
            catch (Exception exx)
            {
                return chapters;
            }
            return chapters;
        }
    }
}
