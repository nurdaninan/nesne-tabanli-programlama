using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nurdan_inan396529
{
    internal class Program
    {
        public class TikTokVideo
        {
            private string user_name;
            private long user_id;
            private long video_id;
            private string video_desc;
            private long video_length;
            private string video_link;
            private long n_likes;
            private long n_shares;
            private long n_comments;
            private long n_plays;
            private long n_ad_views;
            public string User_name
            {
                get { return user_name; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("user_name boş veya null olamaz.");
                    }

                    user_name = value;
                }
            }

            public long User_id
            {
                get { return user_id; }
                set
                {
                    user_id = value;
                }
            }

            public long Video_id
            {
                get { return video_id; }
                set
                {
                    video_id = value;
                }
            }
            public string Video_desc
            {
                get { return video_desc; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("video_desc boş veya null olamaz.");
                    }

                    video_desc = value;
                }
            }
            public long Video_length
            {
                get { return video_length; }
                set
                {
                    video_length = value;
                }
            }
            public string Video_link
            {
                get { return video_link; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("video_link boş veya null olamaz.");
                    }

                    video_link = value;
                }
            }
            public long N_likes
            {
                get { return n_likes; }
                set
                {
                    n_likes = value;
                }
            }
            public long N_shares
            {
                get { return n_shares; }
                set
                {
                    n_shares = value;
                }
            }
            public long N_comments
            {
                get { return n_comments; }
                set
                {
                    n_comments = value;
                }
            }
            public long N_plays
            {
                get { return n_plays; }
                set
                {
                    n_plays = value;
                }
            }
            public long N_ad_views
            {
                get { return n_ad_views; }
                set
                {
                    n_ad_views = value;
                }
            }
        }

        static void Main(string[] args)
        {
            //TikTokVideo tkv1 = new TikTokVideo();
            //tkv1.User_name = "tiktok";
            //tkv1.User_id = 107955;
            //tkv1.Video_id = 6994857340839234821;
            //tkv1.Video_desc = "1 guy. 100M followers @khaby.lame";
            //tkv1.Video_length = 34;
            //tkv1.Video_link = "https://www.tiktok.com/@tiktok/video/6994857340839234821?lang=en";
            //tkv1.N_likes = 384700;
            //tkv1.N_shares = 6087;
            //tkv1.N_comments = 56200;
            //tkv1.N_plays = 3100000;
            //tkv1.N_ad_views = 40000;

            System.Console.ReadKey();
        }
    }
}
