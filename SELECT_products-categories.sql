CREATE TABLE IF NOT EXISTS "Products" (
  "id" serial primary key,
  "Name" varchar() NOT NULL
);

CREATE TABLE IF NOT EXISTS "Categories" (
  "id" serial primary key,
  "Name" varchar() NOT NULL
);

CREATE TABLE IF NOT EXISTS "Products_Categories" (
  "idProducts" int,
  "idCategories" int
);

CREATE UNIQUE INDEX idx_U_Products_Categories
  ON "Products_Categories"("idProducts", "idCategories")
  USING btree(name, cdate);

SELECT p."Name" AS ProductName
	, c."Name" AS CategoryName 
FROM "Products" as p
	LEFT JOIN "Products_Categories" as pc ON p."id" = pc."idProducts"
	LEFT JOIN "Categories" as c ON pc."idCategories" = c."id";
