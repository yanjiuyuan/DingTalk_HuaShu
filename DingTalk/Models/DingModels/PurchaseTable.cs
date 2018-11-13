namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseTable")]
    public partial class PurchaseTable
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
        /// �۸�
        /// </summary>
        [StringLength(500)]
        public string Price { get; set; }
        /// <summary>
        /// Ŀ��
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
        /// �ɹ�Ա
        /// </summary>
        [StringLength(100)]
        public string PurchaseMan { get; set; }
        /// <summary>
        /// �ɹ�ԱId
        /// </summary>
        [StringLength(100)]
        public string PurchaseManId { get; set; }
        /// <summary>
        /// �ɹ�����(�㲿���ɹ�����Ʒ�ɹ����ͻ���������ɹ�)
        /// </summary>
        [StringLength(50)]
        public string purchaseType { get; set; }
        
    }
}
