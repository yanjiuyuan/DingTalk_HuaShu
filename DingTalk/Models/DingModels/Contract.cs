namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        /// <summary>
        /// ��ˮ��(Ԥ��)
        /// </summary>
        [StringLength(300)]
        public string TaskId { get; set; }
        /// <summary>
        /// ��ͬ���
        /// </summary>
        [StringLength(300)]
        public string ContractNo { get; set; }
        /// <summary>
        /// ��ͬǩ����λ
        /// </summary>
        [StringLength(300)]
        public string SignUnit { get; set; }
        /// <summary>
        /// ���۾���
        /// </summary>
        [StringLength(300)]
        public string SalesManager { get; set; }
        /// <summary>
        /// ��ͬ����
        /// </summary>
        [StringLength(300)]
        public string ContractType { get; set; }
        /// <summary>
        /// ��ͬ·��(Ԥ��)
        /// </summary>
        [StringLength(500)]
        public string Path { get; set; }
        /// <summary>
        /// ��ͬ���ļ�(Ԥ��)
        /// </summary>
        [StringLength(500)]
        public string FilePath { get; set; }
    }
}
