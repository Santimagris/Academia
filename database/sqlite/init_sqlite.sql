-- =========================================================
-- Academia de Danzas - Esquema SQLite (según diagrama original)
-- Usando PRIMARY KEY AUTOINCREMENT (INTEGER).
-- Incluye índices en alumna y restricción de unicidad en pagos.
-- =========================================================
PRAGMA foreign_keys = ON;

-- Limpieza si ya existen
DROP TABLE IF EXISTS inasistencia;
DROP TABLE IF EXISTS pago;
DROP TABLE IF EXISTS alumna_danza;
DROP TABLE IF EXISTS danza;
DROP TABLE IF EXISTS alumna;

-- ============================
-- Tabla: alumna
-- ============================
CREATE TABLE alumna (
  id         INTEGER PRIMARY KEY AUTOINCREMENT,
  nombre     TEXT NOT NULL,
  apellido   TEXT NOT NULL,
  dni        TEXT NOT NULL UNIQUE,       -- evita duplicados de documento
  direccion  TEXT,
  status     TEXT NOT NULL DEFAULT 'activa'
);

-- Índices útiles para búsquedas
CREATE INDEX idx_alumna_apellido_nombre ON alumna(apellido, nombre);
CREATE INDEX idx_alumna_dni ON alumna(dni);

-- ============================
-- Tabla: danza
-- ============================
CREATE TABLE danza (
  id      INTEGER PRIMARY KEY AUTOINCREMENT,
  nombre  TEXT NOT NULL UNIQUE,           -- no repetir danzas
  status  TEXT NOT NULL DEFAULT 'activa'
);

-- ============================
-- Tabla: alumna_danza (pivot AlumnaXDanza)
-- ============================
CREATE TABLE alumna_danza (
  id_alumna    INTEGER NOT NULL,
  id_danza     INTEGER NOT NULL,
  fecha_inicio TEXT NOT NULL,   -- formato ISO YYYY-MM-DD
  fecha_fin    TEXT,            -- NULL = sigue cursando

  PRIMARY KEY (id_alumna, id_danza, fecha_inicio),
  FOREIGN KEY (id_alumna) REFERENCES alumna(id) ON DELETE CASCADE,
  FOREIGN KEY (id_danza)  REFERENCES danza(id)  ON DELETE CASCADE
);

-- ============================
-- Tabla: pago
-- ============================
CREATE TABLE pago (
  id             INTEGER PRIMARY KEY AUTOINCREMENT,
  fecha_pago     TEXT NOT NULL,   -- ISO YYYY-MM-DD
  mes            TEXT NOT NULL,   -- AAAAMM o nombre del mes
  monto_abonado  REAL NOT NULL CHECK (monto_abonado >= 0),
  status         TEXT NOT NULL DEFAULT 'confirmado',
  id_alumna      INTEGER NOT NULL,

  FOREIGN KEY (id_alumna) REFERENCES alumna(id) ON DELETE CASCADE
);

-- Restricción: un pago por mes y alumna
CREATE UNIQUE INDEX uq_pago_alumna_mes ON pago(id_alumna, mes);

-- ============================
-- Tabla: inasistencia
-- ============================
CREATE TABLE inasistencia (
  id         INTEGER PRIMARY KEY AUTOINCREMENT,
  id_alumna  INTEGER NOT NULL,
  fecha      TEXT NOT NULL,   -- ISO YYYY-MM-DD
  motivo     TEXT,

  UNIQUE (id_alumna, fecha),  -- una inasistencia por alumna y día
  FOREIGN KEY (id_alumna) REFERENCES alumna(id) ON DELETE CASCADE
);
