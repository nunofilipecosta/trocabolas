﻿CREATE TABLE [dbo].[Memberships] (
    [UserId]                                  UNIQUEIDENTIFIER NOT NULL,
    [ApplicationId]                           UNIQUEIDENTIFIER NOT NULL,
    [Password]                                NVARCHAR (128)   NOT NULL,
    [PasswordFormat]                          INT              NOT NULL,
    [PasswordSalt]                            NVARCHAR (128)   NOT NULL,
    [Email]                                   NVARCHAR (256)   NULL,
    [PasswordQuestion]                        NVARCHAR (256)   NULL,
    [PasswordAnswer]                          NVARCHAR (128)   NULL,
    [IsApproved]                              BIT              NOT NULL,
    [IsLockedOut]                             BIT              NOT NULL,
    [CreateDate]                              DATETIME         NOT NULL,
    [LastLoginDate]                           DATETIME         NOT NULL,
    [LastPasswordChangedDate]                 DATETIME         NOT NULL,
    [LastLockoutDate]                         DATETIME         NOT NULL,
    [FailedPasswordAttemptCount]              INT              NOT NULL,
    [FailedPasswordAttemptWindowStart]        DATETIME         NOT NULL,
    [FailedPasswordAnswerAttemptCount]        INT              NOT NULL,
    [FailedPasswordAnswerAttemptWindowsStart] DATETIME         NOT NULL,
    [Comment]                                 NVARCHAR (256)   NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [MembershipEntity_Application] FOREIGN KEY ([ApplicationId]) REFERENCES [dbo].[Applications] ([ApplicationId]),
    CONSTRAINT [MembershipEntity_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

