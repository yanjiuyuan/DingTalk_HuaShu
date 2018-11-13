namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receiving")]
    public partial class Receiving
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(300)]
        public string TaskId { get; set; }
        /// <summary>
        /// ���ʵ�λ
        /// </summary>
        [StringLength(200)]
        public string ReceivingUnit { get; set; }
        /// <summary>
        /// �ļ����
        /// </summary>
        [StringLength(100)]
        public string ReceivingNo { get; set; }
        /// <summary>
        /// �ļ��ĺ�
        /// </summary>
        [StringLength(100)]
        public string FileNo { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [StringLength(100)]
        public string ReceivingTime { get; set; }
        /// <summary>
        /// ��Ҫ����
        /// </summary>
        public string MainIdea { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string Suggestion { get; set; }
        /// <summary>
        /// �쵼��ʾ
        /// </summary>
        public string Leadership { get; set; }
        /// <summary>
        /// �а첿���İ����
        /// </summary>
        public string Review { get; set; }
        /// <summary>
        /// ������ʵ���
        /// </summary>
        public string HandleImplementation { get; set; }
    }
}
