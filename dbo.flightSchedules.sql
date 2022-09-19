CREATE TABLE [dbo].[flightSchedules] (
    [Flight no]      INT          NOT NULL,
    [Flight ID]      INT          NOT NULL,
    [Departure time] INT          NOT NULL,
    [Arrival time]   INT          NULL,
    [Origin]         VARCHAR (50) NULL,
    [Destination]    VARCHAR (50) NULL,
    [Status]         VARCHAR (50) NULL,
    [Cost]           REAL         NULL,
    [Booked seats]   INT          NULL,
    [Left seats]     INT          NULL,
    PRIMARY KEY CLUSTERED ([Flight no] ASC),
    CONSTRAINT [FK_flightSchedules_flightInfo] FOREIGN KEY ([Flight no]) REFERENCES [dbo].[flightInfo] ([Flight No]),
    CONSTRAINT [FK_flightSchedules_flightBookings] FOREIGN KEY ([Flight ID]) REFERENCES [dbo].[flightBookings] ([Flight ID])
);

