using System;
using System.Collections.Generic;

namespace freelancehunt
{
    internal class clsProfile
    {
        public static Dictionary<int, string> dicProjectStateName = new Dictionary<int, string>()
    {
      {
        11,
        "принимаются ставки"
      },
      {
        12,
        "ставки не принимаются"
      },
      {
        13,
        "выбран исполнитель"
      },
      {
        21,
        "проект успешно завершен"
      },
      {
        22,
        "проект закрыт заказчиком"
      },
      {
        23,
        "истекло время актуальности"
      },
      {
        24,
        "нарушены правила сервиса"
      },
      {
        25,
        "проект не выполнен"
      },
      {
        26,
        "проект не оплачен"
      },
      {
        31,
        "ожидает оплаты"
      },
      {
        32,
        "заблокирован фрилансерами"
      },
      {
        33,
        "закрыт модератором"
      }
    };

        public long id { get; private set; }

        public string url { get; private set; }

        public string url_private_message { get; private set; }

        public string url_avatar { get; private set; }

        public bool is_freelancer { get; private set; }

        public bool is_employer { get; private set; }

        public string login { get; private set; }

        public string fname { get; private set; }

        public string sname { get; private set; }

        public DateTime birth_date { get; private set; }

        public long rating { get; private set; }

        public long rating_position { get; private set; }

        public string country_name_ru { get; private set; }

        public string city_name_ru { get; private set; }

        public DateTime creation_date { get; private set; }

        public int positive_reviews { get; private set; }

        public int negative_reviews { get; private set; }

        public bool is_phone_verifie { get; private set; }

        public bool is_fname_verified { get; private set; }

        public bool is_birth_date_verified { get; private set; }

        public bool is_wmid_verified { get; private set; }

        public bool is_okpay_verified { get; private set; }

        public bool is_email_verified { get; private set; }

        public List<object[]> table
        {
            get
            {
                return new List<object[]>()
        {
          new object[2]
          {
            (object) "Логин",
            (object) this.login
          },
          new object[2]
          {
            (object) "Имя",
            (object) (this.fname + " " + this.sname)
          },
          new object[2]
          {
            (object) "Страна",
            (object) this.country_name_ru
          },
          new object[2]
          {
            (object) "Город",
            (object) this.city_name_ru
          },
          new object[2]
          {
            (object) "Фрилансер",
            this.is_freelancer ? (object) "Да" : (object) "Нет"
          },
          new object[2]
          {
            (object) "Заказчик",
            this.is_employer ? (object) "Да" : (object) "Нет"
          },
          new object[2]
          {
            (object) "Дата рождения",
            (object) this.birth_date.ToLongDateString()
          },
          new object[2]
          {
            (object) "Рейтинг",
            (object) this.rating
          },
          new object[2]
          {
            (object) "Позиция",
            (object) this.rating_position
          },
          new object[2]
          {
            (object) "Кол-во положительных отзывов",
            (object) this.positive_reviews
          },
          new object[2]
          {
            (object) "Кол-во отрицательных отзывов",
            (object) this.negative_reviews
          }
        };
            }
        }

        static clsProfile()
        {
        }

        public clsProfile(clsJSON block)
        {
            foreach (string[] strArray in block.data)
            {
                strArray[0] = strArray[0].ToLower();
                if (strArray[0].CompareTo("profile_id") == 0)
                    this.id = this.StringToInt64(strArray[1]);
                if (strArray[0].CompareTo("url") == 0)
                    this.url = strArray[1];
                if (strArray[0].CompareTo("url_private_message") == 0)
                    this.url_private_message = strArray[1];
                if (strArray[0].CompareTo("avatar") == 0)
                    this.url_avatar = strArray[1];
                if (strArray[0].CompareTo("is_freelancer") == 0)
                    this.is_freelancer = this.StringToBool(strArray[1]);
                if (strArray[0].CompareTo("is_employer") == 0)
                    this.is_employer = this.StringToBool(strArray[1]);
                if (strArray[0].CompareTo("login") == 0)
                    this.login = strArray[1];
                if (strArray[0].CompareTo("fname") == 0)
                    this.fname = strArray[1];
                if (strArray[0].CompareTo("sname") == 0)
                    this.sname = strArray[1];
                if (strArray[0].CompareTo("birth_date") == 0)
                    this.birth_date = clsTimeConvert.dtFrom8061(strArray[1]);
                if (strArray[0].CompareTo("rating") == 0)
                    this.rating = this.StringToInt64(strArray[1]);
                if (strArray[0].CompareTo("rating_position") == 0)
                    this.rating_position = this.StringToInt64(strArray[1]);
                if (strArray[0].CompareTo("country_name_ru") == 0)
                    this.country_name_ru = strArray[1];
                if (strArray[0].CompareTo("city_name_ru") == 0)
                    this.city_name_ru = strArray[1];
                if (strArray[0].CompareTo("creation_date") == 0)
                    this.creation_date = clsTimeConvert.dtFrom8061(strArray[1]);
                if (strArray[0].CompareTo("positive_reviews") == 0)
                    this.positive_reviews = this.StringToInt(strArray[1]);
                if (strArray[0].CompareTo("negative_reviews") == 0)
                    this.negative_reviews = this.StringToInt(strArray[1]);
                if (strArray[0].CompareTo("is_phone_verified") == 0)
                    this.is_phone_verifie = this.StringToBool(strArray[1]);
                if (strArray[0].CompareTo("is_fname_verified") == 0)
                    this.is_fname_verified = this.StringToBool(strArray[1]);
                if (strArray[0].CompareTo("is_birth_date_verified") == 0)
                    this.is_birth_date_verified = this.StringToBool(strArray[1]);
                if (strArray[0].CompareTo("is_wmid_verified") == 0)
                    this.is_wmid_verified = this.StringToBool(strArray[1]);
                if (strArray[0].CompareTo("is_okpay_verified") == 0)
                    this.is_okpay_verified = this.StringToBool(strArray[1]);
                if (strArray[0].CompareTo("is_email_verified") == 0)
                    this.is_email_verified = this.StringToBool(strArray[1]);
            }
        }

        private long StringToInt64(string str)
        {
            long result = 0L;
            long.TryParse(str, out result);
            return result;
        }

        private int StringToInt(string str)
        {
            int result = 0;
            int.TryParse(str, out result);
            return result;
        }

        private bool StringToBool(string str)
        {
            return str.CompareTo("true") == 0 || str.CompareTo("1") == 0;
        }
    }
}
