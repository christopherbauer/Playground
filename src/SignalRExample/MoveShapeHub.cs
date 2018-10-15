using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRExample
{
    public class MoveShapeHub : Hub
    {
        private Broadcaster _broadcaster;
        public MoveShapeHub() : this (Broadcaster.Instance)
        {
            
        }

        private MoveShapeHub(Broadcaster instance)
        {
            _broadcaster = instance;
        }

        public void UpdateModel(ShapeModel clientShapeModel)
        {
            clientShapeModel.LastUpdatedBy = Context.ConnectionId;
            _broadcaster.UpdateShape(clientShapeModel);
        }
    }
}