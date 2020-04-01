namespace GitExercise
{
    class myClass
    {
        private string _name;
        private string _adress;
        public myClass(string name,string adress)
        {
            _name = name;
            _adress = adress;           
        }
        public string name
        {
            get{ return _name; }
        }
        public string adress
        {
            get { return _adress;}
        }
        public override string ToString()
        {
            return $"Navnet er {name}, og bor på adressen {adress} ";
        }
    }
}