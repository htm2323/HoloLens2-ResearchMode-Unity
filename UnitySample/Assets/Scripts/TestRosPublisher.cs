using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class TestRosPublisher : UnityPublisher<MessageTypes.Sensor.CompressedImage>
    {
        public string FrameId = "Hololens";
        public Texture2D image;

        // Start is called before the first frame update
        protected override void Start()
        {
            base.Start();
            //InitializeMessage();
        }

        // Update is called once per frame
        void Update()
        {
            var message = new MessageTypes.Sensor.CompressedImage
            {
                data = image.EncodeToPNG()
            };

            Publish(message);

            Debug.Log("publishing message");

            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                var message = new MessageTypes.Sensor.CompressedImage
                {
                    data = image.EncodeToPNG()
                };

                Publish(message);

                Debug.Log("publishing message");
            }*/
        }

        private void InitializeMessage()
        {

        }

        private void UpdateMessage()
        {

        }
    }
}