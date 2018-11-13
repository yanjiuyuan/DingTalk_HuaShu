namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    /// <summary>
    /// �칫��Ʒ
    /// </summary>
    public partial class OfficeSupplies
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(300)]
        public string TaskId { get; set; }
        /// <summary>
        /// ���ϱ���
        /// </summary>
        [StringLength(500)]
        public string CodeNo { get; set; }
        /// <summary>
        /// ��������
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
    }
}
