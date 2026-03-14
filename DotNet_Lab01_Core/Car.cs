namespace DotNet_Lab01_Core
{
    public class Car // : object
    {
        private string _name;
        public string Name 
        { 
            get { return _name; }
			set { if(value != null && value.Length >= 2) _name = value; }
        }
        public string Description { get; set; }
        public int ManufactirngYear { get; set; }
        public float Speed { get; set; }
        public bool IsElectric { get; set; }
		public string Color { get; set; }

        public Car() { }

		public Car(string name, string description, int year, string color) 
        {
            Name = name;
            Description = description;
            ManufactirngYear = year;
            Color = color;
		}

        override public string ToString()
        {
			return $"Car Name: {Name}\nDescription: {Description}\nManufacturing Year: {ManufactirngYear}\nColor: {Color}\nSpeed: {Speed}\nIsElectric: {(IsElectric ? "Y" : "N")}";
		}
	}
}
