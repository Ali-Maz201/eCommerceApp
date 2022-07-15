using System.Globalization;

namespace Exceptions.ProductExceptions
{
    public class CreateProductBadRequestException : Exception
    {
        public CreateProductBadRequestException() : base() {}

        public CreateProductBadRequestException(string message) : base(message) { }

        public CreateProductBadRequestException(string message, params object[] args) 
            : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
    }
}
