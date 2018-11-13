namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OverTime")]
    public partial class OverTime
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        /// <summary>
        /// ��ˮ��
        /// </summary>
        [StringLength(100)]
        public string TaskId { get; set; }
        /// <summary>
        /// �Ӱ�����
        /// </summary>
        [StringLength(100)]
        public string DateTime { get; set; }
        /// <summary>
        /// �Ӱ࿪ʼʱ��
        /// </summary>
        [StringLength(100)]
        public string StartTime { get; set; }
        /// <summary>
        /// �Ӱ����ʱ��
        /// </summary>
        [StringLength(100)]
        public string EndTimeTime { get; set; }
        /// <summary>
        /// �Ӱ�ʱ��
        /// </summary>
        [StringLength(100)]
        public string UseTime { get; set; }
        /// <summary>
        /// �Ӱ�����
        /// </summary>
        public string OverTimeContent { get; set; }
        /// <summary>
        /// ��Чʱ��
        /// </summary>
        public string EffectiveTime { get; set; }
    }
}
