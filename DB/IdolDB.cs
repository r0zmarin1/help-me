using System.Text.Json;

class IdolDB
{
        List<Idol> idols;

        public IdolDB()
        {
            //load file (json)
            if (!File.Exists("idol.json"))
                idols = new List<Idol>();
            else
                using (FileStream fs = new FileStream("idol.json", FileMode.OpenOrCreate))
                {
                    idols = JsonSerializer.Deserialize<List<Idol>>(fs);
                }
        }

        public List<Idol> Search(string text)
        {
            List<Idol> result = new();
            foreach (var idol in idols)
            {
                if (idol.Name.Contains(text) || idol.SceneName.Contains(text))
                    result.Add(idol);
            }
            return result;
        }

        public bool Update(Idol idol)
        {
            if (!idols.Contains(idol))
                return false;
            Save();
            return true;
        }

        public Idol Create()
        {
            Idol newIdol = new Idol { };
            idols.Add(newIdol);
            return newIdol;
        }

        public bool Delete(Idol idol)
        {
            if (!idols.Contains(idol))
                return false;
            idols.Remove(idol);
            Save();
            return true;
        }


        void Save()
        {
            // save file (json)
            using (FileStream fs = new FileStream("idol.json", FileMode.Create))
            {
                JsonSerializer.Serialize(fs, idols);
            }
        }
    }
