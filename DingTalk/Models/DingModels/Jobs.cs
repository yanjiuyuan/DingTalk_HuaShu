namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Jobs
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        /// <summary>
        /// ְλ
        /// </summary>
        [StringLength(100)]
        public string JobName { get; set; }
        /// <summary>
        /// Ҫ��
        /// </summary>
        [StringLength(300)]
        public string Require { get; set; }
        /// <summary>
        /// �����ص�
        /// </summary>
        [StringLength(200)]
        public string WorkPlace { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [StringLength(100)]
        public string CreateTime { get; set; }
        /// <summary>
        /// н��
        /// </summary>
        [StringLength(100)]
        public string Pay { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(100)]
        public string Url { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(100)]
        public string BigType { get; set; }
        /// <summary>
        /// С��
        /// </summary>
        [StringLength(100)]
        public string Type { get; set; }
    }
}
