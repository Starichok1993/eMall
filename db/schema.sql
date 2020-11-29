-- Table db_version
CREATE TABLE db_version (
  Id int(11) unsigned NOT NULL,
  Version VARCHAR(32) NOT NULL,
  Description VARCHAR(1024) NOT NULL,
  DateApplied DATETIME NOT NULL,
  PRIMARY KEY (Id)
 );

-- Table product
CREATE TABLE product (
  Id int(11) unsigned NOT NULL,
  Name VARCHAR(32) NOT NULL,
  Description TEXT NOT NULL,
  Price DECIMAL(13,2) NOT NULL,
  PRIMARY KEY (Id)
 );