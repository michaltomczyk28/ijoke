import React from "react";
import Joke from "../components/Joke";
import styled from "styled-components";

const StyledSection = styled("section")({
  height: "100vh",
  margin: "0 350px",
});

const MainPage = () => {
  return (
    <StyledSection>
      <header>
        <h1>wolne-zarty.pl</h1>
      </header>
      <div>
        <Joke />
        <div>
          <input />
          <button>Dodaj zart</button>
        </div>
      </div>
    </StyledSection>
  );
};

export default MainPage;
