--
-- PostgreSQL database dump
--

-- Dumped from database version 17.2
-- Dumped by pg_dump version 17.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: warehouse_stock; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA warehouse_stock;


ALTER SCHEMA warehouse_stock OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: products; Type: TABLE; Schema: warehouse_stock; Owner: postgres
--

CREATE TABLE warehouse_stock.products (
    id integer NOT NULL,
    product_id integer,
    product_name character varying(800),
    quantity integer,
    unit character varying(300),
    date date,
    date_update date
);


ALTER TABLE warehouse_stock.products OWNER TO postgres;

--
-- Name: products_id_seq; Type: SEQUENCE; Schema: warehouse_stock; Owner: postgres
--

CREATE SEQUENCE warehouse_stock.products_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE warehouse_stock.products_id_seq OWNER TO postgres;

--
-- Name: products_id_seq; Type: SEQUENCE OWNED BY; Schema: warehouse_stock; Owner: postgres
--

ALTER SEQUENCE warehouse_stock.products_id_seq OWNED BY warehouse_stock.products.id;


--
-- Name: users; Type: TABLE; Schema: warehouse_stock; Owner: postgres
--

CREATE TABLE warehouse_stock.users (
    id integer NOT NULL,
    username character varying(150),
    email character varying(500),
    password character varying(800),
    is_admin boolean,
    date_joined date
);


ALTER TABLE warehouse_stock.users OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE; Schema: warehouse_stock; Owner: postgres
--

CREATE SEQUENCE warehouse_stock.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE warehouse_stock.users_id_seq OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE OWNED BY; Schema: warehouse_stock; Owner: postgres
--

ALTER SEQUENCE warehouse_stock.users_id_seq OWNED BY warehouse_stock.users.id;


--
-- Name: products id; Type: DEFAULT; Schema: warehouse_stock; Owner: postgres
--

ALTER TABLE ONLY warehouse_stock.products ALTER COLUMN id SET DEFAULT nextval('warehouse_stock.products_id_seq'::regclass);


--
-- Name: users id; Type: DEFAULT; Schema: warehouse_stock; Owner: postgres
--

ALTER TABLE ONLY warehouse_stock.users ALTER COLUMN id SET DEFAULT nextval('warehouse_stock.users_id_seq'::regclass);


--
-- Data for Name: products; Type: TABLE DATA; Schema: warehouse_stock; Owner: postgres
--

COPY warehouse_stock.products (id, product_id, product_name, quantity, unit, date, date_update) FROM stdin;
4	562	đinh dù	50	bịch	2025-01-04	2025-01-05
3	23	vít	40	bịch	2025-01-04	2025-01-05
5	345	đinh ốc	456	bịch	2025-01-05	\N
\.


--
-- Data for Name: users; Type: TABLE DATA; Schema: warehouse_stock; Owner: postgres
--

COPY warehouse_stock.users (id, username, email, password, is_admin, date_joined) FROM stdin;
5	admin	admin@gmail.com	$MYHASH$V1$10000$f/gh9WzG4bjvTF0kIBoMn69GTzsdiS/aeaa7jw/lTf7iUh+c	f	2025-01-01
6	thong	thong@gmail.com	$MYHASH$V1$10000$vGvmvkUiK4CAPUWb40/OCB2xwWNwjxFeJV+yncNiSIo1L5dN	f	2025-01-01
8	yae	yae@gmail.com	$MYHASH$V1$10000$8hGUlfjxvejB5m5RMJ10PIqu5GGxGqIVEtsdn7qUU706of3c	f	2025-01-04
\.


--
-- Name: products_id_seq; Type: SEQUENCE SET; Schema: warehouse_stock; Owner: postgres
--

SELECT pg_catalog.setval('warehouse_stock.products_id_seq', 5, true);


--
-- Name: users_id_seq; Type: SEQUENCE SET; Schema: warehouse_stock; Owner: postgres
--

SELECT pg_catalog.setval('warehouse_stock.users_id_seq', 8, true);


--
-- Name: products products_pkey; Type: CONSTRAINT; Schema: warehouse_stock; Owner: postgres
--

ALTER TABLE ONLY warehouse_stock.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (id);


--
-- Name: users users_pkey; Type: CONSTRAINT; Schema: warehouse_stock; Owner: postgres
--

ALTER TABLE ONLY warehouse_stock.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);


--
-- PostgreSQL database dump complete
--

