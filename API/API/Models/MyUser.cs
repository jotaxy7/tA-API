namespace API.Models
{
    /// <summary>
    /// Dados dos clientes da loja
    /// </summary>
    public class MyUser 
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Morada do cliente
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Código postal da morada do cliente
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// País da morada do cliente
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Número de contribuinte
        /// </summary>
        public string TaxNumber { get; set; }

        /// <summary>
        /// Número de telémovel do cliente
        /// </summary>
        public string CellPhone { get; set; }
    }
}
