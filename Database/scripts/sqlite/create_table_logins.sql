CREATE TABLE "logins" (
	"id"	INTEGER NOT NULL,
	"username"	VARCHAR(50) NOT NULL UNIQUE,
	"password"	VARCHAR(64) NOT NULL UNIQUE,
	"expired"	DATETIME NOT NULL,
	"active"	INTEGER NOT NULL,
	"last_login"	DATETIME,
	"firebase_token"	TEXT,
	"post_code"	TEXT,
	"postname"	VARCHAR(32),
	PRIMARY KEY("id")
)