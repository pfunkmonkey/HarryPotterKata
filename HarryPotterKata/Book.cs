namespace HarryPotterCatter
{
    public class Book : IBasketItem
    {
        public int Isbn { get; set; }
        public string Name { get; set; }
        public override bool Equals(object obj)
        {
            var book = (Book)obj;

            return Isbn == book.Isbn;
        }
    }
}
