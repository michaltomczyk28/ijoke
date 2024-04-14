import React from "react";
import styled from "styled-components";
import JokeCreator from "../components/JokeCreator";
import JokesList from "../components/JokesList";

const Container = styled("section")({
  height: "100vh",
});

const MainContent = styled("div")({
  margin: "50px auto",
  display: "flex",
  maxWidth: "900px",
  padding: "20px",
  gap: "50px",
  justifyContent: "center",
  flexDirection: "column",
});

const StyledHeader = styled("header")({
  padding: "10px",
});

const MainPage = () => {
  return (
    <Container>
      <StyledHeader>
        <h1>wolne-zarty.pl</h1>
      </StyledHeader>
      <MainContent>
        <JokesList />
        <JokeCreator />
      </MainContent>
    </Container>
  );
};

export default MainPage;
