namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vote")]
    public partial class Vote
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [StringLength(200)]
        public string ApplyMan { get; set; }
        /// <summary>
        /// ������Id
        /// </summary>
        [StringLength(200)]
        public string ApplyManId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(200)]
        public string Title { get; set; }
        /// <summary>
        /// ѡ��(���Ÿ���)
        /// </summary>
        public string Option { get; set; }
        /// <summary>
        /// ͶƱ����(���Ÿ���)
        /// </summary>
        [StringLength(200)]
        public string VoteCount { get; set; }
        /// <summary>
        /// �����ύ��Id����(���Ÿ���)
        /// </summary>
        public string SubmitterId { get; set; }
    }
}
