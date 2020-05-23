/*
Created: 30.04.2020
Modified: 23.05.2020
Model: PostgreSQL 10
Database: PostgreSQL 10
*/

-- Create tables section -------------------------------------------------

-- Table Device

CREATE TABLE "Device"
(
  "device_pk" Serial NOT NULL,
  "device_number" Character varying,
  "inventory_number" Character varying(20) NOT NULL,
  "network_name" Character varying(255),
  "creator_pk" Integer,
  "device_type_pk" Integer NOT NULL,
  "aquire_date" Date NOT NULL,
  "writeoff_date" Date
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship4" ON "Device" ("creator_pk")
;
CREATE INDEX "IX_device_is_type_of" ON "Device" ("device_type_pk")
;
ALTER TABLE "Device" ADD CONSTRAINT "PK_Device" PRIMARY KEY ("device_pk")
;
ALTER TABLE "Device" ADD CONSTRAINT "Инвентаризационный номер" UNIQUE ("inventory_number")
;
-- Table Structure_unit

CREATE TABLE "Structure_unit"
(
  "unit_pk" Serial NOT NULL,
  "name" Character varying(100) NOT NULL,
  "parent_unit_pk" Integer
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship1" ON "Structure_unit" ("parent_unit_pk")
;
ALTER TABLE "Structure_unit" ADD CONSTRAINT "PK_Structure_unit" PRIMARY KEY ("unit_pk")
;
-- Table Cabinet

CREATE TABLE "Cabinet"
(
  "cabinet_pk" Serial NOT NULL,
  "number" Character varying NOT NULL,
  "unit_pk" Integer NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Contains" ON "Cabinet" ("unit_pk")
;
ALTER TABLE "Cabinet" ADD CONSTRAINT "PK_Cabinet" PRIMARY KEY ("cabinet_pk")
;
-- Table Creator

CREATE TABLE "Creator"
(
  "creator_pk" Serial NOT NULL,
  "name" Character varying NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

ALTER TABLE "Creator" ADD CONSTRAINT "PK_Creator" PRIMARY KEY ("creator_pk")
;
-- Table Using_matherial

CREATE TABLE "Using_matherial"
(
  "matherial_pk" Serial NOT NULL,
  "name" Character varying NOT NULL,
  "cost" Money NOT NULL,
  "device_pk" Integer,
  "type_pk" Integer NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship5" ON "Using_matherial" ("device_pk")
;
CREATE INDEX "IX_Type_of" ON "Using_matherial" ("type_pk")
;
ALTER TABLE "Using_matherial" ADD CONSTRAINT "PK_Using_matherial" PRIMARY KEY ("matherial_pk")
;
-- Table Matherial_type

CREATE TABLE "Matherial_type"
(
  "type_pk" Serial NOT NULL,
  "name" Character varying NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

ALTER TABLE "Matherial_type" ADD CONSTRAINT "PK_Matherial_type" PRIMARY KEY ("type_pk")
;
-- Table Device_type

CREATE TABLE "Device_type"
(
  "device_type_pk" Serial NOT NULL,
  "name" Character varying NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

ALTER TABLE "Device_type" ADD CONSTRAINT "PK_Device_type" PRIMARY KEY ("device_type_pk")
;
-- Table Statement

CREATE TABLE "Statement"
(
  "statement_pk" Serial NOT NULL,
  "name" Character varying(20) NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

ALTER TABLE "Statement" ADD CONSTRAINT "PK_Statement" PRIMARY KEY ("statement_pk")
;
-- Table History_record

CREATE TABLE "History_record"
(
  "record_pk" Serial NOT NULL,
  "cabinet_pk" Integer,
  "device_pk" Integer NOT NULL,
  "start_date" Date,
  "end_date" Date,
  "statement_pk" Integer
)
WITH (
  autovacuum_enabled=true)
;

CREATE INDEX "IX_Relationship3" ON "History_record" ("cabinet_pk")
;
CREATE INDEX "IX_Relationship10" ON "History_record" ("statement_pk")
;
ALTER TABLE "History_record" ADD CONSTRAINT "PK_History_record" PRIMARY KEY ("record_pk","device_pk")
;
-- Table Print_history_record

CREATE TABLE "Print_history_record"
(
  "print_record_pk" Serial NOT NULL,
  "file_name" Character varying NOT NULL,
  "owner" Character varying,
  "print_date" Date NOT NULL,
  "device_pk" Integer NOT NULL
)
WITH (
  autovacuum_enabled=true)
;

ALTER TABLE "Print_history_record" ADD CONSTRAINT "PK_Print_history_record" PRIMARY KEY ("print_record_pk","device_pk")
;
-- Create foreign keys (relationships) section ------------------------------------------------- 

ALTER TABLE "Structure_unit" ADD CONSTRAINT "Units-link" FOREIGN KEY ("parent_unit_pk") REFERENCES "Structure_unit" ("unit_pk") ON DELETE CASCADE ON UPDATE RESTRICT
;

ALTER TABLE "Cabinet" ADD CONSTRAINT "Contains" FOREIGN KEY ("unit_pk") REFERENCES "Structure_unit" ("unit_pk") ON DELETE CASCADE ON UPDATE RESTRICT
;

ALTER TABLE "Device" ADD CONSTRAINT "Created" FOREIGN KEY ("creator_pk") REFERENCES "Creator" ("creator_pk") ON DELETE SET NULL ON UPDATE RESTRICT
;

ALTER TABLE "Using_matherial" ADD CONSTRAINT "Requires" FOREIGN KEY ("device_pk") REFERENCES "Device" ("device_pk") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Using_matherial" ADD CONSTRAINT "Type_of" FOREIGN KEY ("type_pk") REFERENCES "Matherial_type" ("type_pk") ON DELETE SET NULL ON UPDATE RESTRICT
;

ALTER TABLE "Device" ADD CONSTRAINT "device_is_type_of" FOREIGN KEY ("device_type_pk") REFERENCES "Device_type" ("device_type_pk") ON DELETE SET NULL ON UPDATE RESTRICT
;

ALTER TABLE "History_record" ADD CONSTRAINT "Have_history" FOREIGN KEY ("device_pk") REFERENCES "Device" ("device_pk") ON DELETE CASCADE ON UPDATE RESTRICT
;

ALTER TABLE "History_record" ADD CONSTRAINT "writen_in_history" FOREIGN KEY ("cabinet_pk") REFERENCES "Cabinet" ("cabinet_pk") ON DELETE SET NULL ON UPDATE RESTRICT
;

ALTER TABLE "Print_history_record" ADD CONSTRAINT "dev_printRecord_rel" FOREIGN KEY ("device_pk") REFERENCES "Device" ("device_pk") ON DELETE CASCADE ON UPDATE RESTRICT
;

ALTER TABLE "History_record" ADD CONSTRAINT "devStateRel" FOREIGN KEY ("statement_pk") REFERENCES "Statement" ("statement_pk") ON DELETE RESTRICT ON UPDATE RESTRICT
;




