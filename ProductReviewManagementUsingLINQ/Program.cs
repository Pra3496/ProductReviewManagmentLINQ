namespace ProductReviewManagementUsingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<ProductReviewModel> productList= new List<ProductReviewModel>()
            {
                new ProductReviewModel() { ProductId = 1, UserId = 12, Rating = 4, Review = "Good", isLike = true },
                new ProductReviewModel() { ProductId = 2, UserId = 19, Rating = 5, Review = "Perfect", isLike = true },
                new ProductReviewModel() { ProductId = 3, UserId = 18, Rating = 3, Review = "good", isLike = false },
                new ProductReviewModel() { ProductId = 4, UserId = 17, Rating = 5, Review = "Perfect", isLike = true },
                new ProductReviewModel() { ProductId = 5, UserId = 16, Rating = 2, Review = "bad", isLike = false },
                new ProductReviewModel() { ProductId = 6, UserId = 15, Rating = 3, Review = "average", isLike = true },
                new ProductReviewModel() { ProductId = 7, UserId = 14, Rating =4, Review = "Good", isLike = true },
                new ProductReviewModel() { ProductId = 8, UserId = 13, Rating = 5, Review = "Excellent", isLike = true },
                new ProductReviewModel() { ProductId = 9, UserId = 11, Rating = 4, Review = "Good", isLike = false },
                new ProductReviewModel() { ProductId = 10, UserId = 21, Rating = 1, Review = "very bad", isLike = false },

                new ProductReviewModel() { ProductId = 11, UserId = 32, Rating = 4, Review = "Good", isLike = true },
                new ProductReviewModel() { ProductId = 12, UserId = 39, Rating = 5, Review = "Perfect", isLike = true },
                new ProductReviewModel() { ProductId = 13, UserId = 28, Rating = 3, Review = "good", isLike = false },
                new ProductReviewModel() { ProductId = 14, UserId = 27, Rating = 5, Review = "Perfect", isLike = true },
                new ProductReviewModel() { ProductId = 15, UserId = 36, Rating = 2, Review = "bad", isLike = false },
                new ProductReviewModel() { ProductId = 16, UserId = 35, Rating = 3, Review = "average", isLike = true },
                new ProductReviewModel() { ProductId = 17, UserId = 24, Rating = 4, Review = "Good", isLike = true },
                new ProductReviewModel() { ProductId = 18, UserId = 23, Rating = 5, Review = "Excellent", isLike = true },
                new ProductReviewModel() { ProductId = 19, UserId = 31, Rating = 4, Review = "Good", isLike = false },
                new ProductReviewModel() { ProductId = 20, UserId = 41, Rating = 1, Review = "very bad", isLike = false },

                new ProductReviewModel() { ProductId = 21, UserId = 46, Rating = 4, Review = "Good", isLike = true },
                new ProductReviewModel() { ProductId = 22, UserId = 47, Rating = 5, Review = "Perfect", isLike = true },
                new ProductReviewModel() { ProductId = 23, UserId = 38, Rating = 3, Review = "good", isLike = false },
                new ProductReviewModel() { ProductId = 24, UserId = 45, Rating = 5, Review = "Perfect", isLike = true }

            };
            Management management = new Management();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("\nWell-Come To PRODUCT MANEGMENT REVIEW Using LINQ\n");
                Console.WriteLine("1 : Add List");
                Console.WriteLine("2 : Display List");
                Console.WriteLine("3 : Retrive Top 3 From List");
                Console.WriteLine("4 : Retrive Product Rating greater then 3");
                Console.WriteLine("0 : Exit\n");
                Console.Write("\nEnter Option : ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {

                    case 1:
                        management.AddProductReview(productList);
                        Console.Write("\nPress any key...");
                        Console.ReadKey();
                        break;
                    case 2:
                        management.DisplayProductReviewList(productList);
                        Console.Write("\nPress any key...");
                        Console.ReadKey();
                        break;
                    case 3:
                        management.RetriveTop3Records();
                        Console.Write("\nPress any key...");
                        Console.ReadKey();
                        break;
                    case 4:
                        management.RetriveProductRatingGreaterThen3(productList);
                        Console.Write("\nPress any key...");
                        Console.ReadKey();
                        break;
                    case 0:
                        flag= false;
                        break;

                }
            }
           


        }
    }
}