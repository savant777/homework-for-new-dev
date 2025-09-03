CREATE DATABASE ClassRegistrationDB;
GO

USE ClassRegistrationDB;
GO

CREATE TABLE Classes (
    ClassID INT IDENTITY(1,1) PRIMARY KEY,
    ClassName NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    MonthRegistered INT NOT NULL,
    PosterPath NVARCHAR(500)
);

CREATE TABLE Registrations (
    RegistrationID INT IDENTITY(1,1) PRIMARY KEY,
    ClassID INT NOT NULL,
    RegisteredDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);
GO

INSERT INTO Classes (ClassName, Description, MonthRegistered, PosterPath)
VALUES
(N'A (Jan)', N'Class A (Jan). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 1, N'class_poster/poster-001.png'),
(N'B (Jan)', N'Class B (Jan). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 1, N'class_poster/poster-002.png'),
(N'A (Feb)', N'Class A (Feb). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 2, N'class_poster/poster-003.png'),
(N'A (Mar)', N'Class A (Mar). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 3, N'class_poster/poster-004.png'),
(N'A (Apr)', N'Class A (Apr). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 4, N'class_poster/poster-005.png'),
(N'B (Apr)', N'Class B (Apr). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 4, N'class_poster/poster-006.png'),
(N'A (May)', N'Class A (May). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 5, N'class_poster/poster-007.png'),
(N'A (Jun)', N'Class A (Jun). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 6, N'class_poster/poster-008.png'),
(N'A (Jul)', N'Class A (Jul). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 7, N'class_poster/poster-009.png'),
(N'A (Aug)', N'Class A (Aug). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 8, N'class_poster/poster-010.png'),
(N'B (Aug)', N'Class B (Aug). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 8, N'class_poster/poster-011.png'),
(N'C (Aug)', N'Class C (Aug). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 8, N'class_poster/poster-012.png'),
(N'A (Sep)', N'Class A (Sep). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 9, N'class_poster/poster-013.png'),
(N'B (Sep)', N'Class B (Sep). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 9, N'class_poster/poster-014.png'),
(N'C (Sep)', N'Class C (Sep). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 9, N'class_poster/poster-015.png'),
(N'A (Oct)', N'Class A (Oct). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 10, N'class_poster/poster-016.png'),
(N'B (Oct)', N'Class B (Oct). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 10, N'class_poster/poster-017.png'),
(N'A (Nov)', N'Class A (Nov). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 11, N'class_poster/poster-018.png'),
(N'A (Dec)', N'Class A (Dec). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 12, N'class_poster/poster-019.png'),
(N'B (Dec)', N'Class B (Dec). Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 12, N'class_poster/poster-020.png');
GO