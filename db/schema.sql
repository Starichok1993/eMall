-- Table db_version
CREATE TABLE db_version (
  Id int(11) unsigned NOT NULL,
  Version VARCHAR(32) NOT NULL,
  Description VARCHAR(1024) NOT NULL,
  DateApplied DATETIME NOT NULL,
  PRIMARY KEY (Id)
 );