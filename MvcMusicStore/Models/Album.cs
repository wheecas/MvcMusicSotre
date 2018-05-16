namespace MvcMusicStore.Models
{
    /// <summary>
    /// ר��
    /// </summary>
    public class Album
	{
        public virtual int AlbumId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual int ArtistId { get; set; }
        public string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        /// <summary>
        /// �������ԣ������ҵ������
        /// </summary>
        public virtual Artist Artist { get; set; }


    }
}
