using OrderProcessingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.Classes
{
    public class VideoSlip:ISlip
    {

      
        private PackingSlipTypeEnum packingSlipType;

        public PackingSlipTypeEnum PackingSlipType
        {
            get { return packingSlipType; }
            set { packingSlipType = PackingSlipTypeEnum.Video; }
        }

        public VideoSlip(string videoText)
        {
            if (videoText == "Learning to Ski")
            {
                AddFreeFirstAidVideo();
            }
        
        }
        private bool AddFreeFirstAidVideo()
        {
            
            //add some logic
            return true;
        
        }
    }
}
