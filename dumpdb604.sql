--
-- PostgreSQL database dump
--

-- Dumped from database version 10.17
-- Dumped by pg_dump version 10.17

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
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO postgres;

--
-- Name: requests; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.requests (
    applicantname text,
    phonenumber text,
    email text,
    planvisitdate timestamp without time zone,
    planvisittime text,
    personcountingroup integer,
    isconsentedforprocessingofpd boolean,
    eventid bigint,
    id integer NOT NULL
);


ALTER TABLE public.requests OWNER TO postgres;

--
-- Name: requests_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.requests_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.requests_id_seq OWNER TO postgres;

--
-- Name: requests_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.requests_id_seq OWNED BY public.requests.id;


--
-- Name: requests id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.requests ALTER COLUMN id SET DEFAULT nextval('public.requests_id_seq'::regclass);


--
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
20210708114330_InitialCreate	5.0.7
\.


--
-- Data for Name: requests; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.requests (applicantname, phonenumber, email, planvisitdate, planvisittime, personcountingroup, isconsentedforprocessingofpd, eventid, id) FROM stdin;
Денис	\N	\N	0001-01-01 00:00:00	\N	0	f	0	1
Денис	\N	\N	0001-01-01 00:00:00	\N	0	f	0	2
Михаил	\N	\N	0001-01-10 12:12:12	\N	5	t	2	3
Михаил	\N	\N	0001-01-10 12:12:12	\N	5	t	2	4
Денис	8982	dadavydov@mail.ru	0001-10-01 00:00:00	11:00	12	t	12	5
Аркадий Петрович Валентинов	8982123456	dadavydov@mail.ru	2012-12-12 00:00:00	11:00	7	t	5	0
\.


--
-- Name: requests_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.requests_id_seq', 5, true);


--
-- Name: __EFMigrationsHistory PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


--
-- Name: requests requests_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.requests
    ADD CONSTRAINT requests_pkey PRIMARY KEY (id);


--
-- Name: TABLE "__EFMigrationsHistory"; Type: ACL; Schema: public; Owner: postgres
--

GRANT INSERT ON TABLE public."__EFMigrationsHistory" TO foretkc;


--
-- Name: TABLE requests; Type: ACL; Schema: public; Owner: postgres
--

GRANT INSERT ON TABLE public.requests TO foretkc;


--
-- PostgreSQL database dump complete
--

