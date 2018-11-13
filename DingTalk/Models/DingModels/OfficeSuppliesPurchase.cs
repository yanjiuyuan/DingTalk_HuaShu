namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficeSuppliesPurchase")]
    public partial class OfficeSuppliesPurchase
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        /// <summary>
        /// ��ˮ��
        /// </summary>
        [StringLength(300)]
        public string TaskId { get; set; }
        /// <summary>
        /// ���ϱ���
        /// </summary>
        [StringLength(500)]
        public string CodeNo { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(300)]
        public string Name { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        [StringLength(300)]
        public string Standard { get; set; }
        /// <summary>
        /// ��λ
        /// </summary>
        [StringLength(500)]
        public string Unit { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(500)]
        public string Count { get; set; }
        /// <summary>
        /// ʵ�ʼ۸�
        /// </summary>
        [StringLength(500)]
        public string Price { get; set; }
        /// <summary>
        /// Ԥ�Ƽ۸�
        /// </summary>
        [StringLength(500)]
        public string ExpectPrice { get; set; }
        /// <summary>
        /// ��;
        /// </summary>
        [StringLength(500)]
        public string Purpose { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [StringLength(500)]
        public string UrgentDate { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(500)]
        public string Mark { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [StringLength(300)]
        public string ApplyMan { get; set; }
        /// <summary>
        /// ���벿��
        /// </summary>
        [StringLength(300)]
        public string Dept { get; set; }
    }
}
