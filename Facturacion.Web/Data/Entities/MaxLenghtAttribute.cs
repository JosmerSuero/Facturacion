using System;

namespace Facturacion.Web.Data
{
    internal class MaxLenghtAttribute : Attribute
    {
        private int v;
        private string errorMessage;

        public MaxLenghtAttribute(int v, string ErrorMessage)
        {
            this.v = v;
            errorMessage = ErrorMessage;
        }
    }
}