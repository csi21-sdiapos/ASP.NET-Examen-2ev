--
-- PostgreSQL database dump
--

-- Dumped from database version 14.5
-- Dumped by pg_dump version 14.5

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: sc_evaluacion; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA sc_evaluacion;


ALTER SCHEMA sc_evaluacion OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO postgres;

--
-- Name: eva_cat_evaluacion; Type: TABLE; Schema: sc_evaluacion; Owner: postgres
--

CREATE TABLE sc_evaluacion.eva_cat_evaluacion (
    "Cod_evaluacion" text NOT NULL,
    "Desc_evaluacion" text NOT NULL
);


ALTER TABLE sc_evaluacion.eva_cat_evaluacion OWNER TO postgres;

--
-- Name: eva_tch_notas_evaluacion; Type: TABLE; Schema: sc_evaluacion; Owner: postgres
--

CREATE TABLE sc_evaluacion.eva_tch_notas_evaluacion (
    "Id_nota_evaluacion" integer NOT NULL,
    "Md_uuid" text NOT NULL,
    "Md_fch" timestamp without time zone NOT NULL,
    "Cod_alumno" text NOT NULL,
    "Nota_evaluacion" integer NOT NULL,
    "Cod_evaluacion" text NOT NULL
);


ALTER TABLE sc_evaluacion.eva_tch_notas_evaluacion OWNER TO postgres;

--
-- Name: eva_tch_notas_evaluacion_Id_nota_evaluacion_seq; Type: SEQUENCE; Schema: sc_evaluacion; Owner: postgres
--

CREATE SEQUENCE sc_evaluacion."eva_tch_notas_evaluacion_Id_nota_evaluacion_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE sc_evaluacion."eva_tch_notas_evaluacion_Id_nota_evaluacion_seq" OWNER TO postgres;

--
-- Name: eva_tch_notas_evaluacion_Id_nota_evaluacion_seq; Type: SEQUENCE OWNED BY; Schema: sc_evaluacion; Owner: postgres
--

ALTER SEQUENCE sc_evaluacion."eva_tch_notas_evaluacion_Id_nota_evaluacion_seq" OWNED BY sc_evaluacion.eva_tch_notas_evaluacion."Id_nota_evaluacion";


--
-- Name: eva_tch_notas_evaluacion Id_nota_evaluacion; Type: DEFAULT; Schema: sc_evaluacion; Owner: postgres
--

ALTER TABLE ONLY sc_evaluacion.eva_tch_notas_evaluacion ALTER COLUMN "Id_nota_evaluacion" SET DEFAULT nextval('sc_evaluacion."eva_tch_notas_evaluacion_Id_nota_evaluacion_seq"'::regclass);


--
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."__EFMigrationsHistory" VALUES ('20221231163334_migracion-1', '7.0.1');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20221231165733_migracion-1', '7.0.1');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20221231170102_migracion-1', '7.0.1');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20230102105032_migracion-1', '7.0.1');


--
-- Data for Name: eva_cat_evaluacion; Type: TABLE DATA; Schema: sc_evaluacion; Owner: postgres
--

INSERT INTO sc_evaluacion.eva_cat_evaluacion VALUES ('PR', 'Primera Evaluacion');
INSERT INTO sc_evaluacion.eva_cat_evaluacion VALUES ('SG', 'Segunda Evaluacion');
INSERT INTO sc_evaluacion.eva_cat_evaluacion VALUES ('TC', 'Tercera Evaluacion');


--
-- Data for Name: eva_tch_notas_evaluacion; Type: TABLE DATA; Schema: sc_evaluacion; Owner: postgres
--

INSERT INTO sc_evaluacion.eva_tch_notas_evaluacion VALUES (2, 'A1462431792', '2023-01-02 12:13:51.890016', 'a1sergio', 5, 'PR');
INSERT INTO sc_evaluacion.eva_tch_notas_evaluacion VALUES (3, 'A1718063983', '2023-01-02 12:14:12.180644', 'a1sergio', 6, 'SG');
INSERT INTO sc_evaluacion.eva_tch_notas_evaluacion VALUES (4, 'A2085906379', '2023-01-02 12:14:17.567221', 'a1sergio', 7, 'TC');
INSERT INTO sc_evaluacion.eva_tch_notas_evaluacion VALUES (5, 'A397218816', '2023-01-02 12:14:26.709427', 'b2moises', 6, 'PR');
INSERT INTO sc_evaluacion.eva_tch_notas_evaluacion VALUES (6, 'A2041528131', '2023-01-02 12:14:31.828163', 'b2moises', 7, 'SG');
INSERT INTO sc_evaluacion.eva_tch_notas_evaluacion VALUES (7, 'A1206638192', '2023-01-02 12:14:38.045764', 'b2moises', 8, 'TC');


--
-- Name: eva_tch_notas_evaluacion_Id_nota_evaluacion_seq; Type: SEQUENCE SET; Schema: sc_evaluacion; Owner: postgres
--

SELECT pg_catalog.setval('sc_evaluacion."eva_tch_notas_evaluacion_Id_nota_evaluacion_seq"', 7, true);


--
-- Name: __EFMigrationsHistory PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


--
-- Name: eva_cat_evaluacion PK_eva_cat_evaluacion; Type: CONSTRAINT; Schema: sc_evaluacion; Owner: postgres
--

ALTER TABLE ONLY sc_evaluacion.eva_cat_evaluacion
    ADD CONSTRAINT "PK_eva_cat_evaluacion" PRIMARY KEY ("Cod_evaluacion");


--
-- Name: eva_tch_notas_evaluacion PK_eva_tch_notas_evaluacion; Type: CONSTRAINT; Schema: sc_evaluacion; Owner: postgres
--

ALTER TABLE ONLY sc_evaluacion.eva_tch_notas_evaluacion
    ADD CONSTRAINT "PK_eva_tch_notas_evaluacion" PRIMARY KEY ("Id_nota_evaluacion");


--
-- Name: IX_eva_tch_notas_evaluacion_Cod_evaluacion; Type: INDEX; Schema: sc_evaluacion; Owner: postgres
--

CREATE INDEX "IX_eva_tch_notas_evaluacion_Cod_evaluacion" ON sc_evaluacion.eva_tch_notas_evaluacion USING btree ("Cod_evaluacion");


--
-- Name: eva_tch_notas_evaluacion FK_eva_tch_notas_evaluacion_eva_cat_evaluacion_Cod_evaluacion; Type: FK CONSTRAINT; Schema: sc_evaluacion; Owner: postgres
--

ALTER TABLE ONLY sc_evaluacion.eva_tch_notas_evaluacion
    ADD CONSTRAINT "FK_eva_tch_notas_evaluacion_eva_cat_evaluacion_Cod_evaluacion" FOREIGN KEY ("Cod_evaluacion") REFERENCES sc_evaluacion.eva_cat_evaluacion("Cod_evaluacion") ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

