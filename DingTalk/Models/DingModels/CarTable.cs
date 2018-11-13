namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarTable")]
    public partial class CarTable
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        /// <summary>
        /// ��ˮ��
        /// </summary>
        [StringLength(30)]
        public string TaskId { get; set; }
        /// <summary>
        /// ͬ������
        /// </summary>
        [StringLength(100)]
        public string PeerNumber { get; set; }
        /// <summary>
        /// �ó���ʼʱ��
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// �ó�����ʱ��
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// �ó�����
        /// </summary>
        public string MainContent { get; set; }
        /// <summary>
        /// �ƻ��г�·��
        /// </summary>
        public string PlantTravelWay { get; set; }
        /// <summary>
        /// ʵ���г�·��
        /// </summary>
        public string FactTravelWay { get; set; }
        /// <summary>
        /// ��ʼ������
        /// </summary>
        [StringLength(200)]
        public string StartKilometres { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        [StringLength(200)]
        public string EndKilometres { get; set; }
        /// <summary>
        /// ʹ�ù�����
        /// </summary>
        [StringLength(200)]
        public string UseKilometres { get; set; }
        /// <summary>
        /// �Ƿ񹫳�
        /// </summary>
        public bool? IsPublicCar { get; set; }
        /// <summary>
        /// �Ƿ�ѡ��ռ�õĳ�
        /// </summary>
        public bool? IsChooseOccupyCar { get; set; }
        /// <summary>
        /// ����ΨһId
        /// </summary>
        [StringLength(100)]
        public string CarId { get; set; }
        /// <summary>
        /// ��ʻ��
        /// </summary>
        [StringLength(200)]
        public string DrivingMan { get; set; }
        /// <summary>
        /// ���һ��ռ�ó���Id
        /// </summary>
        [StringLength(200)]
        public string OccupyCarId { get; set; }

    }
}
