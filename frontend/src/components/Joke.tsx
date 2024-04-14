import React from "react";
import styled from "styled-components";

const JokeContainer = styled("div")({
  display: "flex",
});

const JokeWrapper = styled("div")({
  border: "1px solid grey",
});

const Reviewer = styled("div")({});

const UpVote = styled("div")({});

const DownVote = styled("div")({});

const Joke = () => {
  return (
    <JokeContainer>
      <JokeWrapper>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Illum
          possimus doloribus sequi reiciendis accusantium ex nisi tempore
          delectus facere, animi cumque magnam! Rem vel iure, illum obcaecati
          cupiditate esse alias!
        </p>
      </JokeWrapper>
      <Reviewer>
        <UpVote />
        <DownVote />
      </Reviewer>
    </JokeContainer>
  );
};

export default Joke;
