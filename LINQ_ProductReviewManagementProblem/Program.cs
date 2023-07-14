using System.Collections.Generic;

namespace LINQ_ProductReviewManagementProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ProductsReview> products = new List<ProductsReview>();
            ProductReviewManagement review = new ProductReviewManagement();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform the Operation\n1.Insert 25 Records\n2.Retrieve Top 3 Records\n3.Retrieve Records Rating grater than 3 \n4.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        products.Add(new ProductsReview { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 2, UserId = 5, Rating = 4, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 3, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 4, UserId = 7, Rating = 3, Review = "Average", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 5, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 6, UserId = 3, Rating = 5, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 7, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 8, UserId = 6, Rating = 4, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 9, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 10, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 11, UserId = 6, Rating = 3, Review = "Average", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 12, UserId = 8, Rating = 5, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 13, UserId = 2, Rating = 4, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 14, UserId = 4, Rating = 5, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 15, UserId = 6, Rating = 2, Review = "BAverage", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 16, UserId = 5, Rating = 5, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 17, UserId = 9, Rating = 4, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 18, UserId = 11, Rating = 5, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 19, UserId = 14, Rating = 3, Review = "Average", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 20, UserId = 1, Rating = 5, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 21, UserId = 16, Rating = 5, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 22, UserId = 1, Rating = 1, Review = "Worst", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 23, UserId = 10, Rating = 2, Review = "BAverage", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 24, UserId = 11, Rating = 5, Review = "Good", IsLike = true });
                        products.Add(new ProductsReview { ProductId = 25, UserId = 12, Rating = 4, Review = "Good", IsLike = true });
                        Console.WriteLine("Product Details given in Table");
                        Console.WriteLine("------------------------------");
                        foreach (var data in products)
                        {
                            Console.WriteLine(data.ProductId + "\t" + data.UserId + "\t" + data.Rating + "\t" + data.Review + "\t" + data.IsLike);
                        }
                        break;
                        case 2:
                        review.RetrieveTop3Records(products);
                        break;
                        case 3:
                        review.RetrieveRecordsGreaterThan3Ratings(products);
                        break;
                        case 4:
                        flag= false;
                        break;
                }
            }
        }
    }
}