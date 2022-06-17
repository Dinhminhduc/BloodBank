import { Container, CssBaseline } from "@mui/material";
import { useEffect, useState } from "react";
import Catalog from "../../feature/ListProvider/Catalog";
import ListProvider from "../../feature/ListProvider/Catalog";
import { Provider } from "../models/Provider";
import Header from "./Header";

function App() {
  const [providers, setProviders] = useState<Provider[]>([]);

  useEffect(() => {
    fetch("https://localhost:5001/Providers")
      .then((response) => response.json())
      .then((data) => setProviders(data));
  }, []);

  // function addProvider() {
  //   setProviders((prevState) => [
  //     ...prevState,
  //     { name: "provider" + (prevState.length + 1), city: "Ha Noi" },
  //   ]);
  // }
  return (
    <div>
      <CssBaseline />
      <Header />
      <h1>Blood Bank</h1>
      <Container>
        <Catalog providers={providers}/>
      </Container>
    </div>
  );
}

export default App;
