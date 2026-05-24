using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Exceptions
{
    public static class Messages
    {
        public static class Fetch
        {
            public static class Product
            {
                public static string NotFound(Guid id) => $"Product with id {id} not found.";
                public static string Failed = "Failed to read or fetch product.";
                public static string Success = "Product found successfully.";
            }
        }

        public static class Create
        {
            public static class Product
            {
                public static string Success = "Product created successfully.";
                public static string Failed = "Failed to create product.";
            }
        }
    }
}
