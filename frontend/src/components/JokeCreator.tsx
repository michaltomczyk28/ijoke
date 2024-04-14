import styled from "styled-components";

const CreatorContainer = styled("div")({
  margin: "0 auto",
  width: "100%",
});

const CreatorForm = styled("div")({
  marginTop: "10px",
  display: "flex",
  flexDirection: "column",
  gap: "20px",

  input: {
    padding: "15px",
    borderRadius: "6px",
    border: "1px solid black",
  },

  button: {
    cursor: "pointer",
    padding: "5px",
    borderRadius: "6px",
    border: "1px solid black",
  },
});

const JokeCreator = () => {
  return (
    <CreatorContainer>
      <h2>Dodaj nowy zart!</h2>
      <CreatorForm>
        <input required placeholder="tresc zartu*" />
        <input placeholder="autor" />
        <button>Dodaj</button>
      </CreatorForm>
    </CreatorContainer>
  );
};

export default JokeCreator;
