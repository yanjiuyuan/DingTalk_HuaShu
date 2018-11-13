namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(30)]
        public string Name { get; set; }
        /// <summary>
        /// Ʒ��
        /// </summary>
        [StringLength(200)]
        public string Type { get; set; }
        /// <summary>
        /// ���ƺ�
        /// </summary>
        [StringLength(200)]
        public string CarNumber { get; set; }
        /// <summary>
        /// ��ɫ
        /// </summary>
        [StringLength(200)]
        public string Color { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [StringLength(100)]
        public string CreateMan { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [StringLength(100)]
        public string CreateTime { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
        public bool? State { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        [StringLength(500)]
        public string Remark { get; set; }
        /// <summary>
        /// ���һ���ó���ʼʱ��
        /// </summary>
        public DateTime? FinnalStartTime { get; set; }
        /// <summary>
        /// ���һ���ó�����ʱ��
        /// </summary>
        public DateTime? FinnalEndTime { get; set; }
        /// <summary>
        /// �����Ƿ�ռ��
        /// </summary>
        public bool? IsOccupyCar { get; set; }
        /// <summary>
        /// ���һ��ʹ����
        /// </summary>
        [StringLength(200)]
        public string UseMan { get; set; }
        /// <summary>
        /// ���һ��ռ�ó���Id
        /// </summary>
        [StringLength(200)]
        public string OccupyCarId { get; set; }
        /// <summary>
        /// ÿ���ﵥ��
        /// </summary>
        public double? UnitPricePerKilometre { get; set; }
        /// <summary>
        /// ����ʱ���
        /// </summary>
        public string UseTimes { get; set; }
    }
}
