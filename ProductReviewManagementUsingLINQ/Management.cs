using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementUsingLINQ
{
    public class Management
    {
        List<ProductReviewModel> productReviewModels= new List<ProductReviewModel>();

        public void AddProductReview(List<ProductReviewModel> productList)
        {
            this.productReviewModels = productList;
            Console.WriteLine("\n\tReview is Succesfully Added");
        }

        public void DisplayProductReviewList(List<ProductReviewModel> productList)
        {
            Console.WriteLine("\n| ProductId |\t |   UserId  |\t  |   Rating  |\t  |   Review  |\t  |   IsLike  |\n");
            foreach (ProductReviewModel product in productList)
            {
                Console.WriteLine("\t"+product.ProductId+"\t\t"+product.UserId+"\t\t"+product.Rating+"\t\t" +product.Review+"\t\t" +product.isLike);
            }
        }

        public void RetriveTop3Records()
        {
            var result = this.productReviewModels.OrderByDescending(p => p.Rating).Take(3);
            DisplayProductReviewList(result.ToList());
        }

        public void RetriveProductRatingGreaterThen3(List<ProductReviewModel> productReviewModels )
        {
            var result = productReviewModels.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9));
            DisplayProductReviewList(result.ToList());
        }

        public void CountOfReview(List<ProductReviewModel> productReviewModels)
        {
            var groupOfProductId = productReviewModels.GroupBy(p => p.ProductId).Select(p => new { ProductId = p.Key, Count = p.Count() });
            Console.WriteLine("\n| ProductId |\t |    Count  |\n");
            foreach (var product in groupOfProductId)
            {
                Console.WriteLine("\t"+ product.ProductId + "\t\t" + product.Count);
            }
        }


        public void RetrivOnlyProductIdAndReview(List<ProductReviewModel> productReviewModels)
        {
            var listOfProductId = productReviewModels.Select(p => new { p.ProductId, p.Review }).ToList();
            Console.WriteLine("\n| ProductId |\t  |   Review  |\n");
            foreach (var product in listOfProductId)
            {
                Console.WriteLine("\t" + product.ProductId + "\t\t" + product.Review);
            }
        }

        public void SkipTop5RecordsFromProductList(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Skip(5);

            Console.WriteLine("\n| ProductId |\t |   UserId  |\t  |   Rating  |\t  |   Review  |\t  |   IsLike  |\n");
            foreach (var product in result)
            {
                Console.WriteLine("\t" + product.ProductId + "\t\t" + product.UserId + "\t\t" + product.Rating + "\t\t" + product.Review + "\t\t" + product.isLike);
            }
        }

        public void RetriveIsLikeTrue(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Where(p => p.isLike == true);

            Console.WriteLine("\n| ProductId |\t |   UserId  |\t  |   Rating  |\t  |   Review  |\t  |   IsLike  |\n");
            foreach (var product in result)
            {
                Console.WriteLine("\t" + product.ProductId + "\t\t" + product.UserId + "\t\t" + product.Rating + "\t\t" + product.Review + "\t\t" + product.isLike);
            }
        }

        public void AverageRatingProduct(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.GroupBy(p => p.ProductId).Select(p => new { ProductId = p.Key, average = p.Average(x => x.Rating) });

            Console.WriteLine("\n| ProductId |\t |  Average  |\n");
            foreach (var product in result)
            {
                Console.WriteLine("\t" + product.ProductId + "\t\t" + product.average);
            }
        }

        
        public void RetriveNiceMessageRecord(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Where(p => p.Review == "Nice");

            Console.WriteLine("\n| ProductId |\t |   UserId  |\t  |   Rating  |\t  |   Review  |\t  |   IsLike  |\n");
            foreach (var product in result)
            {
                Console.WriteLine("\t" + product.ProductId + "\t\t" + product.UserId + "\t\t" + product.Rating + "\t\t" + product.Review + "\t\t" + product.isLike);
            }
        }

        public void RetriveUserIdDataByRating(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Where(p => p.UserId == 10).OrderBy(p => p.Rating);

            Console.WriteLine("\n| ProductId |\t |   UserId  |\t  |   Rating  |\t  |   Review  |\t  |   IsLike  |\n");
            foreach (var product in result)
            {
                Console.WriteLine("\t" + product.ProductId + "\t\t" + product.UserId + "\t\t" + product.Rating + "\t\t" + product.Review + "\t\t" + product.isLike);
            }
        }
    }
}
