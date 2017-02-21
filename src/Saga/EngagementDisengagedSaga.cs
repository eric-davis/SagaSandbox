using System;
using System.Collections.Generic;

namespace VMS
{
    public sealed class EngagementDisengagedSaga
    {
        public Guid Id { get; }

        public int UserId { get; }

        public DateTime CreatedDateUtc { get; }

        public DateTime? UpdatedDateUtc { get; }

        public DateTime? CompletedDate { get; }

        public EngagementDisengagementSagaStatus Status {get;}

        public Dictionary<int, DisengagementStatus> EngagementStatuses { get; }

        public void Apply<TEvent>(TEvent e)
        {
            throw new NotImplementedException();
        }
    }

    public enum EngagementDisengagementSagaStatus
    {
        Pending,
        InProcess,
        Failed,
        Complete,
        CompleteWithErrors
    }

    public enum DisengagementStatus
    {
        InProcess,
        Failed,
        Complete
    }
}