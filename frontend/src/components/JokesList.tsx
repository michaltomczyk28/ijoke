import { FC } from "react";
import styled from "styled-components";

const jokes = [
  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ab doloremque voluptatibus rerum, aliquam at exercitationem unde labore magnam sint suscipit illum quaerat officia ipsum corporis assumenda, adipisci est iusto nisi.",
  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ab doloremque voluptatibus rerum, aliquam at exercitationem unde labore magnam sint suscipit illum quaerat officia ipsum corporis assumenda, adipisci est iusto nisi.",
  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ab doloremque voluptatibus rerum, aliquam at exercitationem unde labore magnam sint suscipit illum quaerat officia ipsum corporis assumenda, adipisci est iusto nisi.",
  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ab doloremque voluptatibus rerum, aliquam at exercitationem unde labore magnam sint suscipit illum quaerat officia ipsum corporis assumenda, adipisci est iusto nisi.",
  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ab doloremque voluptatibus rerum, aliquam at exercitationem unde labore magnam sint suscipit illum quaerat officia ipsum corporis assumenda, adipisci est iusto nisi.",
];

const JokesListContainer = styled("div")({});

const StyledJokesList = styled("div")({
  marginTop: "10px",
  display: "flex",
  padding: "25px",
  borderBottom: "1px solid black",
  flexDirection: "column",
  gap: "20px",
  maxHeight: "300px",
  overflowY: "scroll",
});

const JokeWrapper = styled("div")({
  display: "flex",
  gap: "20px",
});

const JokeContent = styled("div")({
  padding: "15px",
  borderRadius: "6px",
  border: "1px solid black",
  backgroundColor: "white",
});

const Reviewer = styled("div")({
  display: "flex",
  flexDirection: "column",
  alignItems: "center",
  justifyContent: "center",
});

const UpVote = styled("div")({
  width: "20px",
  height: "20px",
  borderRadius: "50%",
  backgroundColor: "green",
});

const DownVote = styled("div")({
  width: "20px",
  height: "20px",
  borderRadius: "50%",
  backgroundColor: "red",
});

const Joke: FC<{ text: string }> = ({ text }) => {
  return (
    <JokeWrapper>
      <JokeContent>{text}</JokeContent>
      <Reviewer>
        <UpVote>^</UpVote>
        <p>999</p>
        <DownVote>?</DownVote>
      </Reviewer>
    </JokeWrapper>
  );
};

const JokesList = () => {
  return (
    <JokesListContainer>
      <h2>Sprawdz nasze zarty!</h2>
      <StyledJokesList>
        {jokes.map((joke) => (
          <Joke text={joke} />
        ))}
      </StyledJokesList>
    </JokesListContainer>
  );
};

export default JokesList;
