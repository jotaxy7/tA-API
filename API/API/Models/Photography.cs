namespace API.Models
{
    /// <summary>
    /// Objetos a serem vendidos na loja
    /// </summary>
    public class Photography
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome associado à fotografia
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Descrição (opcional) da fotografia
        /// </summary>
        public string Discription { get; set; }

        /// <summary>
        /// Nome do ficheiro que contém a fotografia
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// Data em que a fotografia foi tirada
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Preço de venda da fotografia
        /// </summary>
        public decimal Price { get; set; }
    }
