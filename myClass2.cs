namespace GitExercise
{
    class myClass2
    {
        private string _name;
        private string _adress;
        private string _by;
        public myClass2(string name,string adress,string by)
        {
            _name = name;
            _adress = adress;
            _by = by;           
        }
        public string name
        {
            get{ return _name; }
        }
        public string adress
        {
            get { return _adress;}
        }
        public string by
        {
            get { return _by;}
        }
        public override string ToString()
        {
            return $"Navnet er {name}, og bor på adressen {adress}, i byen {by}. ";
        }
    }
}