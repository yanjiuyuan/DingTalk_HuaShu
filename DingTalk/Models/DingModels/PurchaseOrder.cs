namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseOrder")]
    public partial class PurchaseOrder
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(300)]
        public string TaskId { get; set; }
        /// <summary>
        /// BOM��Id
        /// </summary>
        [StringLength(500)]
        public string BomId { get; set; }
        /// <summary>
        /// ͼ��
        /// </summary>
        [StringLength(300)]
        public string DrawingNo { get; set; }

        [StringLength(300)]
        public string CodeNo { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(500)]
        public string Name { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(500)]
        public string Count { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(500)]
        public string MaterialScience { get; set; }
        /// <summary>
        /// ��λ
        /// </summary>
        [StringLength(500)]
        public string Unit { get; set; }
        /// <summary>
        /// Ʒ��
        /// </summary>
        [StringLength(500)]
        public string Brand { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(500)]
        public string Sorts { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(500)]
        public string Mark { get; set; }
        /// <summary>
        /// �Ƿ��·�
        /// </summary>
        public bool? IsDown { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(200)]
        public string SingleWeight { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(200)]
        public string AllWeight { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [StringLength(200)]
        public string NeedTime { get; set; }
    }
}
