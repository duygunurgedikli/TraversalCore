namespace TraversalCoreProje.Areas.Admin.Models
{
    public class BookingHotelSearchViewModel
    {


            public Datum[] data { get; set; }
            public string message { get; set; }
            public bool status { get; set; }
            public Label label { get; set; }

        

        public class Datum
        {
            public B_Max_Los_Data b_max_los_data { get; set; }
            public bool b_show_entire_homes_checkbox { get; set; }
            public string cc1 { get; set; }
            public bool cjk { get; set; }
            public string dest_id { get; set; }
            public string dest_type { get; set; }
            public string label { get; set; }
            public string label1 { get; set; }
            public string label2 { get; set; }
            public Label[] labels { get; set; }
            public float latitude { get; set; }
            public string lc { get; set; }
            public float longitude { get; set; }
            public int nr_homes { get; set; }
            public int nr_hotels { get; set; }
            public int nr_hotels_25 { get; set; }
            public string photo_uri { get; set; }
            public string roundtrip { get; set; }
            public bool rtl { get; set; }
            public string value { get; set; }
        }

        public class B_Max_Los_Data
        {
            public int defaultLos { get; set; }
            public string experiment { get; set; }
            public int extendedLos { get; set; }
            public bool fullOn { get; set; }
        }

        public class Label
        {
            public string dest_id { get; set; }
            public string dest_type { get; set; }
            public int hl { get; set; }
            public string precomposed { get; set; }
            public string text { get; set; }
        }


    }
}
